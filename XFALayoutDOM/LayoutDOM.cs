using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using XFALayoutDOM.Interfaces;

namespace XFAForms.XFALayoutDOM
{
    public class LayoutDOM : BaseDOM.BaseDOM, ILayoutDOM
    {
        private readonly ILogger _logger;

        public LayoutDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }
    }
}
