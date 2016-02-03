using Castle.Core.Logging;
using XFAForms.LayoutDOM.Interfaces;

namespace XFAForms.LayoutDOM
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
