using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Text;

namespace Anthem.CP.LO.Test
{
    [TestClass]
    public class UserRegistrationTest
    {
        private const string URL = "http://localhost:8080/UserRegistrationService/data/claimSearch?id=4";
        [TestMethod]
        public void TestMethod1()
        {
            WebRequest request = WebRequest.Create(URL);
            request.Method = "POST";
            string postData = "";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
        }
    }
}