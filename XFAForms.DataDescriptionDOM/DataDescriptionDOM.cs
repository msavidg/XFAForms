using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using XFAForms.DataDescriptionDOM.Interfaces;

namespace XFAForms.DataDescriptionDOM
{
    public class DataDescriptionDOM : BaseDOM.BaseDOM, IDataDescriptionDOM
    {
        private readonly ILogger _logger;

        public DataDescriptionDOM(ILogger logger) : base(logger)
        {
            _logger = logger;
        }
    }
}
