using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using ProtoBuf;
using XFAForms.Common;

namespace XFAForms.Web.Controllers
{
    public class FormsController : ApiController
    {
        private readonly Castle.Core.Logging.ILogger _logger;
        private readonly FormEngine.FormEngine _formEngine;

        public FormsController(Castle.Core.Logging.ILogger logger, FormEngine.FormEngine formEngine)
        {

            _logger = logger;

            _formEngine = formEngine;

        }

        [HttpPost]
        public HttpResponseMessage ProcessForms(JobRequest jobRequest)
        {

            _logger.Debug("Begin ProcessForms");

            _formEngine.Initialize(jobRequest);

            _formEngine.ProcessRequests();

            MemoryStream memoryStream = new MemoryStream();

            Serializer.Serialize(memoryStream, jobRequest);

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

            _logger.Debug("End ProcessForms");

            return response;

        }
    }
}
