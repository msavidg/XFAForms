using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using XFAForms.DataDOM.Interfaces;

namespace XFAForms.DataDOM
{
    public class DataDOM : BaseDOM.BaseDOM, IXFADataDOM
    {
        private readonly ILogger _logger;

        public DataDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }
    }
}
