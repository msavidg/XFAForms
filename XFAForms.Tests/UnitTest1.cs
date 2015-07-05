using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Security.Policy;
using System.Web.Configuration;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using ProtoBuf;
using XFAForms.Common;

namespace XFAForms.Tests
{
    [TestClass]
    public class UnitTest1
    {

        private const string Site = "";
        private const string Server = "localhost";

        public void WebTestMethod1()
        {
            using (WebClient webClient = new WebClient())
            {
                String s = webClient.DownloadString(@"http://" + Server + "/XFAForms.Web/api/Forms/Test");
                String r = "Hello, world!";
                Assert.AreEqual(r, JsonConvert.DeserializeObject(s));
            }
        }

        [TestMethod]
        public void ProcessForms()
        {

            var webRequest = WebRequest.Create("http://" + Server + "/XFAForms.Web/api/Forms/ProcessForms");
            webRequest.Timeout = 300000;
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-protobuf";
            webRequest.Credentials = CredentialCache.DefaultNetworkCredentials;

            JobRequest jobRequest = new JobRequest()
            {
                Data = XDocument.Load(@"\\eniac\FormsLibrary$\ECP\DataSchemas\Account.xml").ToString(),
                Forms = new List<string>()
                {
                    "ECP BOR Letter (4 13).XDP"
                }
            };

            using (var writer = new StreamWriter((webRequest.GetRequestStream())))
            {

                Serializer.Serialize(writer.BaseStream, jobRequest);
                writer.Close();

            }

            using (var rsp = webRequest.GetResponse())
            {

                webRequest.GetRequestStream().Close();

                MemoryStream memoryStream;
                using (Stream response = rsp.GetResponseStream())
                {

                    memoryStream = new MemoryStream();

                    var buffer = new byte[1024];

                    int byteCount = 0;

                    do
                    {

                        if (response != null)
                            byteCount = response.Read(buffer, 0, buffer.Length);

                        memoryStream.Write(buffer, 0, byteCount);

                    } while (byteCount > 0);
                }

                memoryStream.Seek(0, SeekOrigin.Begin);

                JobResponse jobResponse = Serializer.Deserialize<JobResponse>(memoryStream);

                rsp.Close();

            }
        }

        string Serialize<T>(MediaTypeFormatter formatter, T value)
        {
            // Create a dummy HTTP Content.
            Stream stream = new MemoryStream();
            var content = new StreamContent(stream);
            /// Serialize the object.
            formatter.WriteToStreamAsync(typeof(T), value, stream, content, null).Wait();
            // Read the serialized string.
            stream.Position = 0;
            return content.ReadAsStringAsync().Result;
        }

        T Deserialize<T>(MediaTypeFormatter formatter, string str) where T : class
        {
            // Write the serialized string to a memory stream.
            Stream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(str);
            writer.Flush();
            stream.Position = 0;
            // Deserialize to an object of type T
            return formatter.ReadFromStreamAsync(typeof(T), stream, null, null).Result as T;
        }

        // Example of use
        public void TestSerialization()
        {
            var value = new JobRequest()
            {
                Data = XDocument.Load(@"\\eniac\FormsLibrary$\ECP\DataSchemas\Account.xml").ToString(),
                Forms = new List<string>()
                {
                    "ECP BOR Letter (4 13).XDP"
                }
            };


            var xml = new XmlMediaTypeFormatter();
            string str = Serialize(xml, value);

            //var json = new JsonMediaTypeFormatter();
            //str = Serialize(json, value);

            // Round trip
            JobRequest person2 = Deserialize<JobRequest>(xml, str);
        }
    }
}
