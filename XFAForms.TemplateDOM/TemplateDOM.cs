using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Castle.Core.Logging;
using XFAForms.Common;
using XFAForms.TemplateDOM.Interfaces;

namespace XFAForms.TemplateDOM
{
    public class TemplateDOM : BaseDOM.BaseDOM, ITemplateDOM
    {
        private readonly ILogger _logger;

        private XDocument _form;
        private XElement _template;

        protected XElement Template
        {
            //TODO: One and only one template?
            get
            {
                if (_template == null)
                {
                    _template = _form.Descendants().First(d => d.Name.LocalName == "template");
                }
                return _template;
            }
        }

        protected XNamespace TemplateNamespace => Template.Name.Namespace;

        public TemplateDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }

        public override void Initialize(XDocument form)
        {

            _logger.Debug("TemplateDOM Initialize!");

            this._form = form;

            ResolveExternalReferences();

        }

        public void ResolveExternalReferences()
        {

            foreach (var r in Template.Descendants().Where(e => e.HasAttributes && e.Attribute("usehref") != null))
            {

                string filename = XFAUtilities.hrefSplitter(r.Attribute("usehref").Value);

            }

        }
    }
}
