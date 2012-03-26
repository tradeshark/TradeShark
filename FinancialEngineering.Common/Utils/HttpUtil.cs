using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinancialEngineering.Common.Utils
{
    public static class HttpUtil
    {
        /// <summary>
        /// Executes an HTTP GET request against the Url specified, returning the 
        /// entire response body in string form.
        /// </summary>
        /// <param name="url">The URL to request</param>
        /// <param name="requireHttp200">
        /// Boolean indicating whether or not to return 
        /// null if the repsonse status code is not 200 (OK).
        /// </param>
        /// <returns>
        /// The response body or null if the response status is required to 
        /// be 200 (OK) but is not
        /// </returns>
        public static string PerformHttpGet(string url, bool requireHttp200)
        {
            string responseBody = null;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (!requireHttp200 || response.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader responseReader =
                                  new StreamReader(responseStream,
                                      string.IsNullOrEmpty(response.CharacterSet) ? Encoding.UTF8 :
                                           Encoding.GetEncoding(response.CharacterSet)))
                            {
                                responseBody = responseReader.ReadToEnd();
                            }
                        }
                    }
                }
            }

            return responseBody;
        }
        public static T PerformHttpGetXmlObject<T>(string url, bool requireHttp200)
        {
            string responseBody = null;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (!requireHttp200 || response.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader responseReader =
                                  new StreamReader(responseStream,
                                      string.IsNullOrEmpty(response.CharacterSet) ? Encoding.UTF8 :
                                           Encoding.GetEncoding(response.CharacterSet)))
                            {
                                XmlSerializer serializer = new XmlSerializer(typeof(T));
                                return (T)serializer.Deserialize(responseReader);
                            }
                        }
                    }
                }
            }

            return default(T);
        }
        public static T PerformHttpGetBinaryObject<T>(string url, bool requireHttp200)
        {
            string responseBody = null;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (!requireHttp200 || response.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                          
                                BinaryFormatter serializer = new BinaryFormatter();

                                return (T)serializer.Deserialize(responseStream);
                        }
                    }
                }
            }

            return default(T);
        }
        /// <summary>
        /// Executes an HTTP POST against the Url specified with the supplied post data, 
        /// returning the entire response body in string form.
        /// </summary>
        /// <param name="url">The URL to post to</param>
        /// <param name="postData">The x-www-form-urlencoded data to post to the URL</param>
        /// <param name="requireHttp200">
        /// Boolean indicating whether or not to return 
        /// null if the repsonse status code is not 200 (OK).
        /// </param>
        /// <returns>
        /// The response body or null if the response status is required to 
        /// be 200 (OK) but is not
        /// </returns>
        public static string PerformHttpPost(string url, string postData, bool requireHttp200)
        {
            string responseBody = null;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = Encoding.UTF8.GetByteCount(postData);

            using (StreamWriter requestWriter = new StreamWriter(request.GetRequestStream()))
            {
                requestWriter.Write(postData);
            }

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(responseStream))
                        {
                            responseBody = responseReader.ReadToEnd();
                        }
                    }
                }
            }

            return responseBody;
        }
    }
}
