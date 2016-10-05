using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using XFAForms.ConnectionSetDataDOM.Interfaces;

namespace XFAForms.ConnectionSetDataDOM
{
    public class ConnectionSetDataDOM : BaseDOM.BaseDOM, IConnectionSetDataDOM
    {
        private readonly ILogger _logger;

        public ConnectionSetDataDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }
    }
}
