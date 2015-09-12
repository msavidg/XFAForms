using System.IO;
using System.Xml.Linq;
using Castle.Core.Logging;
//using Microsoft.ClearScript.V8;
using XFAForms.XFADataDOM.DataTypes;
using XFAForms.XFADataDOM.Interfaces;

namespace XFAForms.XFADataDOM
{
    public class XFADataDOM : BaseDOM.BaseDOM, IXFADataDOM
    {
        private readonly ILogger _logger;
        //private readonly V8ScriptEngine _engine;

        private XDocument _formData;

        public XFADataDOM(ILogger logger) : base(logger)
        //public XFADataDOM(ILogger logger, V8ScriptEngine engine) : base(logger)
        {
            _logger = logger;
            //_engine = engine;
        }

        public override void Initialize(XDocument formData)
        {

            _formData = formData;

            //_engine.Script.account = new DynamicDataXml(_formData.ToString());

            //var a1 = _engine.Evaluate("account.CurrentRisk.Options.nodes.length");
            //var a2 = _engine.Evaluate("account.CurrentRisk.Options.nodes.item(0)");
            //var a3 = _engine.Evaluate("account.CurrentRisk.Options.nodes.item(0).OptionId.value");
            //var a4 = _engine.Evaluate("account.CurrentRisk.Options.nodes.item(0).OptionDetailECP.OptionDetailECPId.value");

        }
    }
}
