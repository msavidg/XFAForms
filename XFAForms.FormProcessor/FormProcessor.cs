using System;
using System.Diagnostics;
using System.Xml.Linq;
using Castle.Core.Logging;
using XFAForms.Common;
using XFAForms.FormProcessor.Interfaces;

namespace XFAForms.FormProcessor
{
    public class FormProcessor : IFormProcessor, IDisposable
    {

        private static XDocument _form;
        private static XDocument _formData;
        private static XDPFile _xdp;

        private readonly ILogger _logger;

        public FormProcessor(ILogger logger)
        {

            _logger = logger;

        }

        public void Initialize(XDocument formData)
        {

            _formData = formData;

        }

        public Byte[] ProcessForm(XDPFile xdp, XDocument form)
        {

            _xdp = xdp;
            _form = form;

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            _logger.Debug("Begin ProcessForm...");

            //TODO: Not sure the order in which to call these...
            _logger.DebugFormat("End ProcessForm, [{0} ms]", stopwatch.ElapsedMilliseconds);

            return new byte[32];

        }

        public void Dispose()
        {
            // Cleanup goes here
            GC.SuppressFinalize(this);
        }
    }
}
