using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Core.Sys.API
{
    public class APIDriver : IDriver
    {
        public Logger SessionLogger { get; set; }
        public APIDriver(Logger Logs)
        {
            SessionLogger = Logs;
        }

        public string GetRequest(APIEnvironment Environment, bool RequireAuth, string RequestUrl)
        {

            try
            {
                string response = string.Empty;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Environment.Url);
                    if (RequireAuth)
                    {
                        Connect(Environment, client);
                    }
                    HttpResponseMessage httpres = client.GetAsync(RequestUrl).Result;
                    if (!httpres.IsSuccessStatusCode)
                        throw new Exception(httpres.ReasonPhrase);
                    
                    response = httpres.Content.ReadAsStringAsync().Result;
                    SessionLogger.WriteLine("GET request successful.", Logger.MessageType.INF);
                }
                return response;
            }
            catch (Exception e)
            {
                SessionLogger.WriteLine("GET failed:" + e.Message, Logger.MessageType.ERR);
                throw new Exception("GET failed: " + e.Message);
            }
        }

        public string PostRequest( APIEnvironment Environment, bool RequireAuth, string RequestUrl, params object[] Params)
        {
            try
            {
                string response = string.Empty;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Environment.Url);
                    if (RequireAuth)
                    {
                        Connect(Environment, client);
                    }
                    HttpResponseMessage httpres = client.PostAsync(RequestUrl, new StringContent(JsonConvert.SerializeObject(Params[0]), Encoding.UTF8, "application/json")).Result;
                    if (!httpres.IsSuccessStatusCode)
                        throw new Exception(httpres.ReasonPhrase);

                    response = httpres.Content.ReadAsStringAsync().Result;
                    SessionLogger.WriteLine("POST request successful.", Logger.MessageType.INF);
                }
                return response;
            }
            catch (Exception e)
            {
                SessionLogger.WriteLine("POST failed:" + e.Message, Logger.MessageType.ERR);
                throw new Exception("POST failed: " + e.Message);
            }
        }

        private void Connect(APIEnvironment Environment, HttpClient Client)
        {
            try
            {
                if (String.IsNullOrEmpty(Environment.Url))
                    throw new Exception("Environment [" + Environment.UniqueName + "] doesn't have endpoint Url. Unable to establish connection...");
                
                if (String.IsNullOrEmpty(Environment.APIKey))
                {             
                    // Get token/apikey from API
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(Environment.Url);
                        var content = new StringContent(JsonConvert.SerializeObject(Environment.Credentials), Encoding.UTF8, "application/json");
                        var httpres = client.PostAsync(Environment.LoginAPI, content).Result;
                        if (httpres.IsSuccessStatusCode)
                        {
                            var res = JsonConvert.DeserializeXmlNode(httpres.Content.ReadAsStringAsync().Result);
                            Environment.APIKey = res.Value;
                        }
                        else
                        {
                            throw new Exception("Failed to authorize connection: " + httpres.ReasonPhrase);
                        }
                    }
                }
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Environment.APIKey);
            }
            catch(Exception e)
            {
                throw new Exception("Unable to establish connection with API: " + e.Message);
            }
            
        }
        /// <summary>
        /// consider removing below if not anymore Driver
        /// </summary>
        public void StartSession()
        {
            //TODO
        }
        public void CloseSession()
        {
            //do nothing
        }

        public void CaptureScreenshot(string Filename)
        {
            //do nothing
        }

        
    }
}
