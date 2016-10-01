using Castle.Core.Logging;
using XFAForms.LocaleSetDOM.Interfaces;

namespace XFAForms.LocaleSetDOM
{
    public class LocaleSetDOM : BaseDOM.BaseDOM, ILocaleSetDOM
    {
        private readonly ILogger _logger;

        public LocaleSetDOM(ILogger logger) : base(logger)
        {
            _logger = logger;
        }
    }
}
