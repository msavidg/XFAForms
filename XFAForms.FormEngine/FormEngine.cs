﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Castle.Core.Logging;
using Castle.Windsor;
using XFAForms.Common;
using XFAForms.FormProcessor.Interfaces;

namespace XFAForms.FormEngine
{
    public class FormEngine
    {
        private readonly ILogger _logger;
        private readonly IFormProcessor _formProcessor;

        private JobRequest _jobRequest;

        public FormEngine(ILogger logger, IFormProcessor formProcessor)
        {

            _logger = logger;

            _formProcessor = formProcessor;

        }

        public void Initialize(JobRequest jobRequest)
        {

            _logger.Debug("Initialize!");

            _jobRequest = jobRequest;

        }

        public void ProcessRequests()
        {

            XDocument formData = XDocument.Parse(_jobRequest.Data);

            _formProcessor.Initialize(formData);

            foreach (XDPFile xdp in _jobRequest.Forms)
            {
                try
                {

                    XDocument form = XDocument.Load(xdp.Filename);

                    _logger.DebugFormat("Processing {0}", xdp.Filename);

                    xdp.Document = _formProcessor.ProcessForm(xdp, form);

                }
                catch (System.Exception ex)
                {

                    xdp.HasError = true;
                    xdp.ErrorMessage = ex.Message;

                    _logger.Error(ex.Message);

                }

            }
        }
    }
}
