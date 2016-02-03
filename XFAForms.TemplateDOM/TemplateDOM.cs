using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Castle.Core.Logging;
using XFAForms.Common;
using XFAForms.TemplateDOM.Interfaces;
using XFAForms.XFAObject.DynamicObjects;
using XFAForms.XFAObject.Interfaces;

namespace XFAForms.TemplateDOM
{
    public class TemplateDOM : BaseDOM.BaseDOM, ITemplateDOM
    {
        private readonly ILogger _logger;

        private XDPFile _xdp;
        private XDocument _form;
        private XElement _formResolved;

        protected XElement Template
        {
            //TODO: One and only one template?
            get
            {
                return _form.Descendants().First(d => d.Name.LocalName == "template");
            }
        }

        protected XNamespace TemplateNamespace => Template.Name.Namespace;

        public TemplateDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }

        public void Initialize(IXFAObject xfaObject, XDPFile xdp, XDocument form)
        {

            _logger.Debug("TemplateDOM Initialize!");

            _xdp = xdp;
            _form = form;

            ResolveExternalReferences();

            xfaObject.template = new DynamicTemplateXml(_formResolved.ToString());

        }

        public void ResolveExternalReferences()
        {

            _logger.Debug("ResolveExternalReferences");

            try
            {

                _formResolved = ResolveExternalReferences(Template);

                _xdp.HasError = false;
                _xdp.ErrorMessage = "No error.";

            }
            catch (SystemException ex)
            {

                _xdp.HasError = true;
                _xdp.ErrorMessage = ex.Message;

                _logger.Debug(ex.Message);

            }
        }

        public XElement ResolveExternalReferences(XElement fragment)
        {

            _logger.Debug("ResolveExternalReferences");

            foreach (var r in fragment.Descendants().Where(e => e.HasAttributes && e.Attribute("usehref") != null).ToList())
            {

                String href = r.Attribute("usehref").Value;

                _logger.DebugFormat("href = {0}", href);

                string hrefFilename = XFAUtilities.FullPath(_xdp.Filename, XFAUtilities.HrefSplitter(href));

                string subFormName = XFAUtilities.GetHrefSubFormName(href);

                _logger.DebugFormat("subform = {0}", subFormName);

                XElement hrefElement = ResolveExternalReferences(XElement.Load(hrefFilename));

                //Embed hrefElement into fragment 

                XElement x = hrefElement.Descendants().FirstOrDefault(e => e.Name.LocalName == "subform" && e.HasAttributes && e.Attribute("name") != null && e.Attribute("name").Value == subFormName);

                if (x == null)
                {

                    _logger.DebugFormat("script = {0}", subFormName);

                    x = hrefElement.Descendants().FirstOrDefault(e => e.Name.LocalName == "script" && e.HasAttributes && e.Attribute("name") != null && e.Attribute("name").Value == subFormName);

                }

                r.ReplaceWith(x);

            }

            return fragment;

        }
    }
}
