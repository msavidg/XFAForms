using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using XFAForms.BaseDOM.Interfaces;

namespace XFAForms.BaseDOM
{
    public class BaseDOM : IBaseDOM
    {
        private readonly ILogger _logger;

        public BaseDOM(ILogger logger)
        {
            _logger = logger;
        }

        public void Initialize()
        {
            _logger.Debug("We are here!");
        }
    }
}
