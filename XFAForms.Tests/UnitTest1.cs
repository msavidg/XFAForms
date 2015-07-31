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
using XFAForms.Web.Controllers;

namespace XFAForms.Tests
{
    [TestClass]
    public class UnitTest1
    {

        private const string Site = "";
        private const string Server = "localhost";

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
                Forms = new List<XMLDataPacket>()
                {
                    new XMLDataPacket(){
                        Id = Guid.NewGuid(),
                    Filename = @"\\eniac\formslibrary$\ecp\Documents\ECP BOR Letter (4 13).xdp"
                    }
                }
            };

            using (var writer = new StreamWriter(webRequest.GetRequestStream()))
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

    }
}
