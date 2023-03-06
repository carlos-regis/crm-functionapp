using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace SharedLibraries_Plugins.Helpers
{
    public class RequestAPI
    {
        public static string POST_Request(string url, string token, string proxy, string body)
        {
            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = token;
            httpRequest.Method = "POST";
            httpRequest.ContentType = "application/json; charset=utf-8";
            //httpRequest.Proxy = new WebProxy(proxy, true) { UseDefaultCredentials = true };

            using (StreamWriter streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(body);
            }

            HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();

                return result;
            }
        }

        public static string TOKEN_Request(string client_id, string client_secret, string url)
        {
            string postData = $"grant_type=client_credentials&client_id={client_id}&client_secret={client_secret}";

            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse response = request.GetResponse();

            using (dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                var responseFromServer = reader.ReadToEnd();

                Token token = new Token();
                token = new JavaScriptSerializer().Deserialize<Token>(responseFromServer);
                token.access_token = "Bearer " + token.access_token;

                return token.access_token;
            }
        }

        [Serializable]
        private class Token
        {
            public string access_token { get; set; }
            public int expires_in { get; set; }
            public string token_type { get; set; }
            public string scope { get; set; }
        }
    }
}
