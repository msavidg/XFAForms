using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Castle.Core.Logging;
using Microsoft.CSharp;
using XFAForms.XMLDataDOM.Interfaces;

namespace XFAForms.XMLDataDOM
{
    public class XMLDataDOM : BaseDOM.BaseDOM, IXMLDataDOM
    {
        private readonly ILogger _logger;

        private XDocument xml;

        public XMLDataDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }

        public void Initialize(XDocument xml)
        {

            _logger.Debug("Initialize!");

            dynamic x = new DynamicXmlParser(xml.Root);

            var builder = new StringBuilder();

            var className = xml.Root.Name.LocalName;

            builder.AppendFormat("public class ").Append(className).Append(" { ");

            foreach (XNode node in xml.Elements().Nodes())
            {
                var n = (node as XElement);

                if (n != null)
                    builder.AppendFormat("string _")
                           .Append(n.Name.LocalName)
                           .Append(" =\"")
                        //.Append(n.Value).Append("\";   public string ")
                        .Append("XXX").Append("\";   public string ")
                           .Append(n.Name.LocalName).Append(" { get { return _")
                           .Append(n.Name.LocalName).Append(";} set{ _")
                           .Append(n.Name.LocalName).Append(" = value ;} } ");
            }
            builder.Append(" } ");

            var compilerParameters = new CompilerParameters();

            compilerParameters.GenerateExecutable = false;
            compilerParameters.GenerateInMemory = true;

            var cCompiler = CSharpCodeProvider.CreateProvider("CSharp");
            var compileResult = cCompiler.CompileAssemblyFromSource(compilerParameters, builder.ToString());

            if (compileResult.Errors.HasErrors)
            {
                throw new Exception("There is error while building type");
            }
            var instanceObject = compileResult.CompiledAssembly.CreateInstance(className);
        }

    }

    class DynamicXmlParser : DynamicObject
    {
        XElement element;


        public DynamicXmlParser(XElement el)
        {
            element = el;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (element == null)
            {
                result = null;
                return false;
            }

            XElement sub = element.Element(binder.Name);

            if (sub == null)
            {
                result = null;
                return false;
            }
            else
            {
                result = new DynamicXmlParser(sub);
                return true;
            }
        }

        public override string ToString()
        {
            if (element != null)
            {
                return element.Value;
            }
            else
            {
                return string.Empty;
            }
        }

        public string this[string attr]
        {
            get
            {
                if (element == null)
                {
                    return string.Empty;
                }

                return element.Attribute(attr).Value;
            }
        }
    }

}
