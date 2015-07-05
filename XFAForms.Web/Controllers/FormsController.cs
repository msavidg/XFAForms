using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.WebSockets;
using Castle.Core.Logging;
using Castle.Windsor;
using ProtoBuf;
using XFAForms.Common;

namespace XFAForms.Web.Controllers
{
    public class FormsController : ApiController
    {
        private readonly ILogger _logger;
        private readonly FormEngine.FormEngine _formEngine;

        public FormsController(ILogger logger, FormEngine.FormEngine formEngine)
        {
            _logger = logger;
            _formEngine = formEngine;
        }

        [HttpGet]
        public String Test()
        {

            _formEngine.Initialize();

            return DateTime.Now.ToLongDateString();

        }

        [HttpPost]
        public HttpResponseMessage ProcessForms(JobRequest requestJob)
        {

            JobResponse jobResponse = new JobResponse()
            {
                Forms = new List<string>() { "Hello.xdp" }
            };

            MemoryStream memoryStream = new MemoryStream();
            Serializer.Serialize(memoryStream, jobResponse);

            HttpResponseMessage response = new HttpResponseMessage()
             {
                 Content = new PushStreamContent((responseStream, httpContent, transportContext) =>
                 {
                     using (responseStream)
                     {
                         responseStream.Write(memoryStream.ToArray(), 0, (int)memoryStream.Length);
                     }
                 }),
                 StatusCode = HttpStatusCode.OK,
             };

            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-protobuf");

            return response;

        }
    }
}
