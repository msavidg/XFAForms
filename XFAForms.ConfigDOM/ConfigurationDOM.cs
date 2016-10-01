using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Castle.Core.Logging;
using XFAForms.BaseDOM.Interfaces;
using XFAForms.ConfigDOM.Interfaces;

namespace XFAForms.ConfigurationDOM
{
    public class ConfigurationDOM : BaseDOM.BaseDOM, IConfigurationDOM
    {

        private readonly ILogger _logger;

        public ConfigurationDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }

        public override void Initialize(XDocument form)
        {
            base.Initialize(form);
        }
    }
}
