using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Castle.Core.Logging;
using XFAForms.Common;
using XFAForms.ConfigDOM.Interfaces;
using XFAForms.ConnectionDataDOM.Interfaces;
using XFAForms.ConnectionSetDOM.Interfaces;
using XFAForms.DataDescriptionDOM.Interfaces;
using XFAForms.FormDOM.Interfaces;
using XFAForms.FormProcessor.Interfaces;
using XFAForms.LayoutDOM.Interfaces;
using XFAForms.TemplateDOM.Interfaces;
using XFAForms.XFADataDOM.Interfaces;
using XFAForms.XMLDataDom.Interfaces;

namespace XFAForms.FormProcessor
{
    public class FormProcessor : IFormProcessor
    {

        private static XDocument _form;
        private static XDPFile _xdp;

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

        public Byte[] ProcessForm(XDPFile xdp, XDocument formData, XDocument form)
        {

            _xdp = xdp;
            _form = form;

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            _logger.Debug("Begin ProcessForm...");

            //TODO: Not sure the order in which to call these...

            _configDom.Initialize(_form);

            _connectionSetDom.Initialize(_form);

            _connectionDataDom.Initialize(_form);

            _xmlDataDom.Initialize(formData);

            _xfaDataDom.Initialize(_form);

            _templateDom.Initialize(_xdp, _form);

            _dataDescriptionDom.Initialize(_form);

            _formDom.Initialize(_form);

            _layoutDom.Initialize(_form);

            _logger.DebugFormat("End ProcessForm, [{0} ms]", stopwatch.ElapsedMilliseconds);

            return new byte[32];

        }
    }
}
