using Castle.Core.Logging;
using XFAForms.DataDOM.Interfaces;

namespace XFAForms.XFADataDOM
{
    public class XFADataDOM : BaseDOM.BaseDOM, IXFADataDOM
    {
        private readonly ILogger _logger;

        public XFADataDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }
    }
}
