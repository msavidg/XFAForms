using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Castle.Core.Logging;
using XFAForms.TemplateDOM.Interfaces;

namespace XFAForms.TemplateDOM
{
    public class TemplateDOM : BaseDOM.BaseDOM, ITemplateDOM
    {
        private readonly ILogger _logger;

        private XDocument _form;

        protected XElement Template
        {
            //TODO: One and only one template?
            get { return _form.Descendants().First(d => d.Name.LocalName == "template"); }
        }

        protected XNamespace TemplateNamespace
        {
            //TODO: A valid xdp should always have this, but do we need to worry about invalid ?
            get { return Template.Attribute("xmlns").Value; }
        }

        public TemplateDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }

        public void Initialize(XDocument form)
        {

            this._form = form;

        }
    }
}
