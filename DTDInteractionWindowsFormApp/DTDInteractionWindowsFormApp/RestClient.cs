using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;


namespace DTDInteractionWindowsFormApp
{
    public enum httpVerb
    {
        GET, 
        POST, 
        PUT,
        DELTE
    }

    class RestClient
    {
        private string baseURL = "https://rxnav.nlm.nih.gov/REST/interaction/list.json";
        public string endPoint { get; set; }
        public string rxNormCodes { get; set; }
        public httpVerb httpMethod { get; set; }

        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }
        
        public string makeRequest()
        {
            string strResponseValue = string.Empty;
            endPoint = baseURL + "?rxcuis=" + rxNormCodes;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();
            using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
            {
                if(response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code " + response.StatusCode.ToString());
                }

                // Process the response stream... (could be JSON, XML, or HTML etc...)

                using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();

                            JsonTextReader jReader = new JsonTextReader(new StringReader(strResponseValue));
                            while (jReader.Read())
                            {
                                if (jReader.Value != null)
                                {
                                    if (jReader.TokenType == JsonToken.PropertyName && ((string)jReader.Value).Equals("fullInteractionTypeGroup"))
                                        Console.WriteLine("Drug To Drug Interaction founds in the medication list");
                                    // Console.WriteLine("Token: {0}, Value: {1}", jReader.TokenType, jReader.Value);
                                }
                                else
                                {
                                    // Ignore
                                    // Console.WriteLine("Token: {0}", jReader.TokenType);
                                }
                            }



                        }
                    }
                } // End of using ResponseStream
            }

            return strResponseValue;
        }

        public bool dTDInteractionExist(string rxNormCodeString)
        {
            string strResponseValue = string.Empty;
            endPoint = baseURL + "?rxcuis=" + rxNormCodeString;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code " + response.StatusCode.ToString());
                }

                // Process the response stream... (could be JSON, XML, or HTML etc...)

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();

                            JsonTextReader jReader = new JsonTextReader(new StringReader(strResponseValue));
                            while (jReader.Read())
                            {
                                if (jReader.Value != null)
                                {
                                    if (jReader.TokenType == JsonToken.PropertyName && ((string)jReader.Value).Equals("fullInteractionTypeGroup"))
                                    { 
                                        // Console.WriteLine("Drug To Drug Interaction founds in the medication list");
                                        // Console.WriteLine("Token: {0}, Value: {1}", jReader.TokenType, jReader.Value);
                                        return true;
                                    }
                                }
                                else
                                {
                                    // Ignore
                                    // Console.WriteLine("Token: {0}", jReader.TokenType);
                                }
                            }



                        }
                    }
                } // End of using ResponseStream
            }

            return false;
        }


    }
}
