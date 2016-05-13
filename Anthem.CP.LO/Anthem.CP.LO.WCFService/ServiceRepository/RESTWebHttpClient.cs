using Anthem.CP.LO.WCFService.DataContracts.OutBound;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;

namespace Anthem.CP.LO.WCFService.ServiceRepository
{
    public static class RESTWebHttpClient
    {
        public static string BaseUrl
        {
            get { return ConfigurationManager.AppSettings["BaseUrl"]; }
        }

        public static IOutBoundResponse MakePutRequest<TIn, TOut>(string url, TIn data)
            where TIn : IOutBoundRequest
            where TOut : IOutBoundResponse
        {
            TOut objResponse = default(TOut);
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(TIn));
            try
            {
                HttpWebRequest request = WebRequest.Create(BaseUrl + url) as HttpWebRequest;
                request.Method = "POST";
                request.ContentType = "application/json";

                using (var sendRequestStream = request.GetRequestStream())
                {
                    jsonSerializer.WriteObject(sendRequestStream, data);
                    sendRequestStream.Close();
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format(
                        "Server error (HTTP {0}: {1}).",
                        response.StatusCode,
                        response.StatusDescription));
                    jsonSerializer = new DataContractJsonSerializer(typeof(TOut));
                    objResponse = (TOut)Convert.ChangeType(jsonSerializer.ReadObject(response.GetResponseStream()), typeof(TOut));
                    objResponse.Success = true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                jsonSerializer = null;
            }
            return objResponse;
        }

        public static IOutBoundResponse MakeGetRequest<TOut>(string url, List<KeyValuePair<string, string>> data)
            where TOut : IOutBoundResponse
        {
            TOut objResponse = default(TOut);
            try
            {
                HttpWebRequest request = WebRequest.Create(AddGetParams((BaseUrl + url), data)) as HttpWebRequest;
                request.Method = "GET";
                request.ContentType = "application/json";

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format(
                        "Server error (HTTP {0}: {1}).",
                        response.StatusCode,
                        response.StatusDescription));
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(TOut));
                    objResponse = (TOut)Convert.ChangeType(jsonSerializer.ReadObject(response.GetResponseStream()), typeof(TOut));
                    objResponse.Success = true;
                }
            }
            catch (Exception e)
            {

            }
            return objResponse;
        }

        private static string AddGetParams(string url, List<KeyValuePair<string, string>> keyValues)
        {
            foreach (var item in keyValues)
            {

                url += item.Key + "=" + item.Value + "&";
            }
            return url;
        }
    }
}