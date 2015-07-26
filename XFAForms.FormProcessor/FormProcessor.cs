using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Castle.Core.Logging;
using XFAForms.ConfigDOM.Interfaces;
using XFAForms.ConnectionDataDOM.Interfaces;
using XFAForms.ConnectionSetDOM.Interfaces;
using XFAForms.DataDescriptionDOM.Interfaces;
using XFAForms.DataDOM.Interfaces;
using XFAForms.FormDOM.Interfaces;
using XFAForms.FormProcessor.Interfaces;
using XFAForms.TemplateDOM.Interfaces;
using XFAForms.XMLDataDOM.Interfaces;
using XFALayoutDOM.Interfaces;

namespace XFAForms.FormProcessor
{
    public class FormProcessor : IFormProcessor
    {
        private readonly ILogger _logger;
        private readonly IConfigDOM _configDom;
        private readonly IConnectionDataDOM _connectionDataDom;
        private readonly IConnectionSetDOM _connectionSetDom;
        private readonly IDataDescriptionDOM _dataDescriptionDom;
        private readonly IFormDOM _formDom;
        private readonly ILayoutDOM _layoutDom;
        private readonly ITemplateDOM _templateDom;
        private readonly IXFADataDOM _xfaDataDom;
        private readonly IXMLDataDOM _xmlDataDom;

        public FormProcessor(ILogger logger, IConfigDOM configDom, IConnectionDataDOM connectionDataDom, IConnectionSetDOM connectionSetDom, IDataDescriptionDOM dataDescriptionDom, IFormDOM formDom, ILayoutDOM layoutDom, ITemplateDOM templateDom, IXFADataDOM xfaDataDom, IXMLDataDOM xmlDataDom)
        {
            _logger = logger;
            _configDom = configDom;
            _connectionDataDom = connectionDataDom;
            _connectionSetDom = connectionSetDom;
            _dataDescriptionDom = dataDescriptionDom;
            _formDom = formDom;
            _layoutDom = layoutDom;
            _templateDom = templateDom;
            _xfaDataDom = xfaDataDom;
            _xmlDataDom = xmlDataDom;
        }

        public Byte[] ProcessForm(XDocument formData, XDocument form)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            _logger.Debug("Begin ProcessForm...");

            _xmlDataDom.Initialize(formData);

            _templateDom.Initialize(form);

            _logger.DebugFormat("End ProcessForm, [{0} ms]", stopwatch.ElapsedMilliseconds);

            return new byte[32];

        }
    }
}
