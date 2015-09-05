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

        private XDPFile _xdp;
        private XDocument _form;

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

        public void Initialize(XDPFile xdp, XDocument form)
        {

            _logger.Debug("TemplateDOM Initialize!");

            _xdp = xdp;
            _form = form;

            ResolveExternalReferences();

        }

        public void ResolveExternalReferences()
        {

            _logger.Debug("ResolveExternalReferences");

            try
            {

                foreach (var r in Template.Descendants().Where(e => e.HasAttributes && e.Attribute("usehref") != null))
                {

                    String href = r.Attribute("usehref").Value;

                    _logger.DebugFormat("href = {0}", href);

                    string hrefFilename = XFAUtilities.FullPathFromRelativeFilename(_xdp.Filename, XFAUtilities.HrefSplitter(href));

                    XDocument hrefElement = XDocument.Load(hrefFilename);

                    string subFormName = XFAUtilities.GetHrefSubFormName(href);

                    _logger.DebugFormat("subform = {0}", subFormName);

                    XElement x = hrefElement.Descendants().FirstOrDefault(e => e.Name.LocalName == "subform" && e.HasAttributes && e.Attribute("name") != null && e.Attribute("name").Value == subFormName);

                    if (x == null)
                    {

                        _logger.DebugFormat("script = {0}", subFormName);

                        x = hrefElement.Descendants().FirstOrDefault(e => e.Name.LocalName == "script" && e.HasAttributes && e.Attribute("name") != null && e.Attribute("name").Value == subFormName);

                    }
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {

                _logger.Debug(ex.Message);

            }
            catch (System.NotSupportedException ex)
            {

                _logger.Debug(ex.Message);

            }
        }
    }
}
