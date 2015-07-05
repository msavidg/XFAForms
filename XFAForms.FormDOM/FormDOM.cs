using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using XFAForms.FormDOM.Interfaces;

namespace XFAForms.FormDOM
{
    public class FormDOM : BaseDOM.BaseDOM, IFormDOM
    {
        private readonly ILogger _logger;

        public FormDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }
    }
}
