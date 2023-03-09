using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using Ttms.Crm.FunctionApp.Shared.EntityModel;
using Ttms.Crm.FunctionApp.Shared.Models;

namespace Ttms.Crm.FunctionApp.Shared.Helpers
{
    public class RequestCMD
    {
        private readonly ILogger logger;
        private string post_url;
        private string get_url;
        private string token;
        private string keyId;
        private readonly string brand;
        private readonly string countryISO;
        private readonly string erpNumber;
        private readonly List<rbtt_configurations> retrievedConfigurationParameters;

        public RequestCMD(ILogger _logger, string _brand, string _countryISO, string _erpNumber,
                                List<rbtt_configurations> _retrievedConfigurationParameters)
        {
            this.logger = _logger;
            this.brand = _brand;
            this.countryISO = _countryISO;
            this.erpNumber = _erpNumber;
            this.retrievedConfigurationParameters = _retrievedConfigurationParameters;
        }

        public void setupRequestCMD()
        {
            logger.LogInformation("setupRequestCMD --- STARTED");

            if (retrievedConfigurationParameters != null || retrievedConfigurationParameters.Count > 0)
            {
                foreach (rbtt_configurations config in retrievedConfigurationParameters)
                {
                    if (config.Attributes[rbtt_configurations.Fields.rbtt_name].ToString() == "Customer Master Data Exchange - keyId")
                    {
                        this.keyId = config.Attributes[rbtt_configurations.Fields.rbtt_Value].ToString();
                    }
                    else if (config.Attributes[rbtt_configurations.Fields.rbtt_name].ToString() == "Customer Master Data Exchange - Token")
                    {
                        this.token = config.Attributes[rbtt_configurations.Fields.rbtt_Value].ToString();
                    }
                    else if (config.Attributes[rbtt_configurations.Fields.rbtt_name].ToString() == "Customer Master Data Exchange - RegisterCustomer")
                    {
                        var endpoint = $"{config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_Value).Replace("{Brand}", brand).Replace("{Country}", countryISO).Replace("{CustomerNumber}", CompleteLeftZeros(erpNumber))}";

                        this.post_url = endpoint;
                    }
                    else if (config.Attributes[rbtt_configurations.Fields.rbtt_name].ToString() == "Customer Master Data Exchange - GetCustomerInformation")
                    {
                        var endpoint = $"{config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_Value).Replace("{Brand}", brand).Replace("{Country}", countryISO).Replace("{CustomerNumber}", CompleteLeftZeros(erpNumber))}";

                        this.get_url = endpoint;
                    }
                }
            }
            logger.LogInformation("setupRequestCMD --- ENDED");

        }

        public void registerCustomer()
        {
            logger.LogInformation("registerCustomer --- STARTED");
            RootGetCustomerInformationResponse getCustomerUpdateReference;

            HttpWebRequest httpRequest = WebRequest.CreateHttp(post_url);
            httpRequest.Method = HttpMethod.Post.ToString();
            httpRequest.Headers.Add(HttpRequestHeader.Authorization, token);
            httpRequest.Headers.Add("keyid", keyId);

            HttpWebResponse response = (HttpWebResponse)httpRequest.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);

            string responseJSON = streamReader.ReadToEnd();
            streamReader.Close();

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(responseJSON)))
            {
                DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings() { UseSimpleDictionaryFormat = true };

                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(RootGetCustomerInformationResponse), settings);
                getCustomerUpdateReference = (RootGetCustomerInformationResponse)ser.ReadObject(stream);
            }
            logger.LogInformation("registerCustomer --- ENDED");
        }

        public RootGetCustomerInformationResponse getCustomerInfo()
        {
            logger.LogInformation("getCustomerInfo --- STARTED");

            RootGetCustomerInformationResponse getCustomerUpdateReference;

            HttpWebRequest httpRequest = WebRequest.CreateHttp(get_url);
            httpRequest.Accept = "*/*";
            httpRequest.ContentType = "application/json; charset=UTF-8";
            httpRequest.Method = HttpMethod.Get.ToString();
            httpRequest.Headers.Add(HttpRequestHeader.Authorization, token);
            httpRequest.Headers.Add("keyid", keyId);

            HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string responseJSON = streamReader.ReadToEnd();

                using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(responseJSON)))
                {
                    DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings() { UseSimpleDictionaryFormat = true };

                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(RootGetCustomerInformationResponse), settings);
                    getCustomerUpdateReference = (RootGetCustomerInformationResponse)ser.ReadObject(stream);
                }
            }

            logger.LogInformation("getCustomerInfo --- ENDED");

            return getCustomerUpdateReference;
        }

        private static string CompleteLeftZeros(string value)
        {
            if (value == null)
                return string.Empty;

            return value.PadLeft(10, '0');
        }
    }
}
