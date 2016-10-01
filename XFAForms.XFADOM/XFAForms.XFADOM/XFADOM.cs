using Castle.Core.Logging;
using XFAForms.XFADOM.Interfaces;

namespace XFAForms.XFADOM
{
    public class XFADOM : BaseDOM.BaseDOM, IXFADOM
    {
        public XFADOM(ILogger logger) : base(logger)
        {
        }
    }
}
