using Castle.Core.Logging;
using XFAForms.SourceSetDOM.Interfaces;

namespace XFAForms.SourceSetDOM
{
    class SourceSetDOM : BaseDOM.BaseDOM, ISourceSetDOM
    {
        private readonly ILogger _logger;

        public SourceSetDOM(ILogger logger) : base(logger)
        {
            _logger = logger;
        }
    }
}
