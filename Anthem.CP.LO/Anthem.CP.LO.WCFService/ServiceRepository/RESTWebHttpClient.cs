using Anthem.CP.LO.WCFService.DataContracts.OutBound;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
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
            try
            {
                HttpWebRequest request = WebRequest.Create(BaseUrl + url) as HttpWebRequest;
                request.Method = "Post";
                request.ContentType = "application/json";
                //DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(data));
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(data);
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
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
                objResponse.Success = false;
            }
            return objResponse;
        }
    }
}