using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Models;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;

namespace SharedLibraries_Plugins.Helpers
{
    public class RequestCMD
    {
        private ITracingService tracingService;
        public string post_url;
        public string get_url;
        public string token;
        public string keyId;
        private string brand;
        private string countryISO;
        private string erpNumber;
        private List<rbtt_configurations> retrievedConfigurationParameters;

        public RequestCMD(ITracingService _tracingService, string _brand, string _countryISO, string _erpNumber,
                                List<rbtt_configurations> _retrievedConfigurationParameters)
        {
            this.tracingService = _tracingService;
            this.brand = _brand;
            this.countryISO = _countryISO;
            this.erpNumber = _erpNumber;
            this.retrievedConfigurationParameters = _retrievedConfigurationParameters;
        }

        public void setupRequestCMD()
        {
            tracingService.Trace("setupRequestCMD --- STARTED");

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
            tracingService.Trace("setupRequestCMD --- ENDED");

        }

        public void registerCustomer()
        {
            tracingService.Trace("registerCustomer --- STARTED");
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
            tracingService.Trace("registerCustomer --- ENDED");
        }

        public RootGetCustomerInformationResponse getCustomerInfo()
        {
            tracingService.Trace("getCustomerInfo --- STARTED");

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

            tracingService.Trace("getCustomerInfo --- ENDED");

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
