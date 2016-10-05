using System.CodeDom;
using System.Xml.Linq;
using Castle.Core.Logging;
using Microsoft.ClearScript.V8;
using XFAForms.Common;
using XFAForms.ConfigurationDOM.Interfaces;
using XFAForms.ConnectionSetDataDOM.Interfaces;
using XFAForms.ConnectionSetDOM.Interfaces;
using XFAForms.DataDescriptionDOM.Interfaces;
using XFAForms.FormDOM.Interfaces;
using XFAForms.LayoutDOM.Interfaces;
using XFAForms.TemplateDOM.Interfaces;
using XFAForms.XFADataDOM.Interfaces;
using XFAForms.XFADOM.Interfaces;
using XFAForms.XFAObject.Interfaces;
using XFAForms.XMLDataDom.Interfaces;

namespace XFAForms.XFADOM
{
    public class XFADOM : BaseDOM.BaseDOM, IXFADOM
    {

        private static XDocument _form;
        private static XDocument _formData;
        private static XDPFile _xdp;

        private readonly ILogger _logger;
        private readonly V8ScriptEngine _engine;
        private readonly IXFAObject _xfaObject;
        private readonly IConfigurationDOM _configDom;
        private readonly IConnectionSetDataDOM _connectionDataDom;
        private readonly IConnectionSetDOM _connectionSetDom;
        private readonly IDataDescriptionDOM _dataDescriptionDom;
        private readonly IFormDOM _formDom;
        private readonly ILayoutDOM _layoutDom;
        private readonly ITemplateDOM _templateDom;
        private readonly IXFADataDOM _xfaDataDom;
        private readonly IXMLDataDOM _xmlDataDom;

        public XFADOM(ILogger logger, V8ScriptEngine engine, IXFAObject xfaObject, IConfigurationDOM configDom, IConnectionSetDataDOM connectionDataDom, IConnectionSetDOM connectionSetDom, IDataDescriptionDOM dataDescriptionDom, IFormDOM formDom, ILayoutDOM layoutDom, ITemplateDOM templateDom, IXFADataDOM xfaDataDom, IXMLDataDOM xmlDataDom) : base(logger)
        {
            _logger = logger;
            _engine = engine;
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

        public void Test(XDPFile xdp, XDocument form)
        {


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

            _engine.AddHostObject("xfa", _xfaObject);

            var a1 = _engine.Evaluate("xfa.record.CurrentRisk.Options.nodes.length");
            var a2 = _engine.Evaluate("xfa.record.CurrentRisk.Options.nodes.item(0)");
            var a3 = _engine.Evaluate("xfa.record.CurrentRisk.Options.nodes.item(0).OptionId.value");
            _engine.Execute("xfa.record.CurrentRisk.Options.nodes.item(0).OptionId.value=99");
            var a5 = _engine.Evaluate("xfa.record.CurrentRisk.Options.nodes.item(0).OptionId.value");
            var a6 = _engine.Evaluate("xfa.record.CurrentRisk.Options.nodes.item(0).OptionDetailECP.OptionDetailECPId.value");

            if (_xdp.Filename.Contains("Sample_001"))
            {

                var x = _xfaObject.template.GetDynamicMemberNames();

                var b1 = _engine.Evaluate("xfa.template.form1.minH");
                var b2 = _engine.Evaluate("xfa.template.form1.layout");

            }
        }
    }
}
