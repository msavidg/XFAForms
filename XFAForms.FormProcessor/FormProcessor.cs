using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Castle.Core.Logging;
using Microsoft.ClearScript.V8;
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
using XFAForms.XFAObject.Interfaces;
using XFAForms.XMLDataDom.Interfaces;

namespace XFAForms.FormProcessor
{
    public class FormProcessor : IFormProcessor, IDisposable
    {

        private static XDocument _form;
        private static XDocument _formData;
        private static XDPFile _xdp;

        private readonly ILogger _logger;
        private readonly IXFAObject _xfaObject;
        private readonly IConfigDOM _configDom;
        private readonly IConnectionDataDOM _connectionDataDom;
        private readonly IConnectionSetDOM _connectionSetDom;
        private readonly IDataDescriptionDOM _dataDescriptionDom;
        private readonly IFormDOM _formDom;
        private readonly ILayoutDOM _layoutDom;
        private readonly ITemplateDOM _templateDom;
        private readonly IXFADataDOM _xfaDataDom;
        private readonly IXMLDataDOM _xmlDataDom;

        public FormProcessor(ILogger logger, V8ScriptEngine engine, IXFAObject xfaObject, IConfigDOM configDom, IConnectionDataDOM connectionDataDom, IConnectionSetDOM connectionSetDom, IDataDescriptionDOM dataDescriptionDom, IFormDOM formDom, ILayoutDOM layoutDom, ITemplateDOM templateDom, IXFADataDOM xfaDataDom, IXMLDataDOM xmlDataDom)
        {

            _logger = logger;
            _xfaObject = xfaObject;
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

            _configDom.Initialize(_form);

            _connectionSetDom.Initialize(_form);

            _connectionDataDom.Initialize(_form);

            _xmlDataDom.Initialize(_formData);

            //xfa.record
            _xfaDataDom.Initialize(_xfaObject, _formData);

            //xfa.template
            _templateDom.Initialize(_xfaObject, _xdp, _form);

            _dataDescriptionDom.Initialize(_form);

            //xfa.form
            _formDom.Initialize(_form);

            _layoutDom.Initialize(_form);

            using (V8ScriptEngine engine = new V8ScriptEngine())
            {

                engine.AddHostObject("xfa", _xfaObject);

                var a1 = engine.Evaluate("xfa.record.CurrentRisk.Options.nodes.length");
                var a2 = engine.Evaluate("xfa.record.CurrentRisk.Options.nodes.item(0)");
                var a3 = engine.Evaluate("xfa.record.CurrentRisk.Options.nodes.item(0).OptionId.value");
                var a4 = engine.Evaluate("xfa.record.CurrentRisk.Options.nodes.item(0).OptionDetailECP.OptionDetailECPId.value");

                if (_xdp.Filename.Contains("ECP Binder Cancel Letter"))
                {

                    var x = _xfaObject.template.GetDynamicMemberNames();

                    var b1 = engine.Evaluate("xfa.template.AccountECP");
                    var b2 = engine.Evaluate("xfa.template.AccountECP.Page1");

                }

            }

            _logger.DebugFormat("End ProcessForm, [{0} ms]", stopwatch.ElapsedMilliseconds);

            return new byte[32];

        }

        public void Dispose()
        {
            // Cleanup goes here
        }
    }
}
