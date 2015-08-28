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
using Castle.Core.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using ProtoBuf;
using XFAForms.Common;
using XFAForms.Web.Controllers;

namespace XFAForms.Tests
{
    [TestClass]
    public class FormsControllerTests
    {

        private const string Server = "localhost";

        [TestMethod, TestCategory("WebApi")]
        public void ProcessForms()
        {

            var webRequest = WebRequest.Create("http://" + Server + "/XFAForms.Web/api/Forms/ProcessForms");
            webRequest.Timeout = 300000;
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-protobuf";
            webRequest.Credentials = CredentialCache.DefaultNetworkCredentials;

            JobRequest jobRequest = new JobRequest()
            {
                Data = XDocument.Load(@"\\" + Server + @"\FormsLibrary$\ECP\DataSchemas\Account.xml").ToString(),
                Forms = new List<XDPFile>()
                {
                    new XDPFile(){
                        Id = Guid.NewGuid(),
                        Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP BOR Letter (4 13).xdp"
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

                JobRequest jobResponse = Serializer.Deserialize<JobRequest>(memoryStream);

                rsp.Close();

            }
        }

        [TestMethod, TestCategory("Controllers")]
        public void ProcessFormsController()
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();

            ConfigDOM.ConfigDOM configDom = new ConfigDOM.ConfigDOM(consoleLogger);
            ConnectionDataDOM.ConnectionDataDOM connectionDataDom = new ConnectionDataDOM.ConnectionDataDOM(consoleLogger);
            ConnectionSetDOM.ConnectionSetDOM connectionSetDom = new ConnectionSetDOM.ConnectionSetDOM(consoleLogger);
            DataDescriptionDOM.DataDescriptionDOM dataDescriptionDom = new DataDescriptionDOM.DataDescriptionDOM(consoleLogger);
            FormDOM.FormDOM formDom = new FormDOM.FormDOM(consoleLogger);
            LayoutDOM.LayoutDOM layoutDom = new LayoutDOM.LayoutDOM(consoleLogger);
            TemplateDOM.TemplateDOM templateDom = new TemplateDOM.TemplateDOM(consoleLogger);
            XFADataDOM.XFADataDOM xfaDataDom = new XFADataDOM.XFADataDOM(consoleLogger);
            XMLDataDOM.XMLDataDOM xmlDataDom = new XMLDataDOM.XMLDataDOM(consoleLogger);

            FormProcessor.FormProcessor formProcessor = new FormProcessor.FormProcessor(consoleLogger, configDom, connectionDataDom, connectionSetDom, dataDescriptionDom, formDom, layoutDom, templateDom, xfaDataDom, xmlDataDom);

            FormEngine.FormEngine formEngine = new FormEngine.FormEngine(consoleLogger, formProcessor);

            Web.Controllers.FormsController formsController = new Web.Controllers.FormsController(consoleLogger, formEngine);

            JobRequest jobRequest = new JobRequest()
            {
                Data = XDocument.Load(@"\\" + Server + @"\FormsLibrary$\ECP\DataSchemas\Account.xml").ToString(),
                Forms = new List<XDPFile>()
                {
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\Commercial Marketing (7 14).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Binder Cancel Letter (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP BOR Letter (4 13).xdp"},
                    new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Cover Letter (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Decline Letter (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Expedited Renewal Document (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Int - Close (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Int - No Order (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Internal Bind Reinstate (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Internal Endorsement (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Internal Void Endorsement (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Invoice (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Policy Reinstate (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Policy Summary (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Renewal Solicitation Letter (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Second Sub Letter (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\ECP Subjectivity Reminder (4 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NAV ECP TLKT II Policy Comparison (10 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NAV ECP TLKT II Policy Highlights (10 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NAV ECP-O TLKT II (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NAV ECP-O TLKT II DEC (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NAV ENV ERS (2 11).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NAV ML 001 IL (1 12).XDP"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NAV NIC ENV POLICY JCKT (1 11).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NAV NSIC ENV POLICY JCKT (1 11).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NAV-CS-CERT-NV (2 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NAV-CS-POL-NV (2 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NAV-ML-002 (11 12).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NAV-ML-TERR DISCLOSURE - Environmental (1 15).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NAV-ML-TERR DISCLOSURE – Environmental  (1 15) (1 15).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NAV-PHN-209-KY (5 10).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NavExpressSM ECP Auto Renewal Application (6 14).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NavExpressSM ECP Auto Renewal Policy Cover Letter (6 14).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NavExpressSM ECP Auto Renewal Proposal Letter (6 14).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 001 IL (3 13).XDP"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 1091 (1 11).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8000 (3 13).XDP"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8001 (3 13).XDP"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8003 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8004 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8006 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8007 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8009 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8010 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8013 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8014 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8018 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8019 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8021 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8022 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8026 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8033 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8034 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8035 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8036 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8039 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8040 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8041 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8042 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8044 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8045 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8047 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8048 (9 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8049 (9 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8050 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8051 (11 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8053 (3 13).XDP"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8054 (3 13).XDP"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8062 (9 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8063 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8067 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8068 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8069 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8070 (3 13).XDP"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8071 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8074 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8075 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8078 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8080 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8081 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8087 (1 15).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8088 (1 15).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8089 (3 13).XDP"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8090 (3 13).XDP"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8091 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8092 (3 13).XDP"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8093 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8094 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8096 (9 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8097 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8098 (3 13).XDP"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8099 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8100 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8101 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8102 (6 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8103 (8 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8109 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8110 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8112 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8113 (3 13).XDP"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8114 (3 13).XDP"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8115 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8117 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8118 (3 13).XDP"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8119 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV 8120 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV CN 01 (11 12).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV Forms List 01 (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV Manuscript (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NENV TRIA Notice Form (3 13).xdp"},
                    //new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NSIC AK NOTICE (8 12).xdp"},
                    new XDPFile(){Id = Guid.NewGuid(),Filename = @"\\"+Server+@"\formslibrary$\ecp\Documents\NSIC TX NOTICE (2 07).xdp"}                }
            };

            var task = formsController.ProcessForms(jobRequest).Content.ReadAsByteArrayAsync();

            task.Wait();

            if (task.IsCompleted)
            {
                MemoryStream memoryStream = new MemoryStream(task.Result);

                JobRequest jobResponse = Serializer.Deserialize<JobRequest>(memoryStream);
            }
        }
    }
}
