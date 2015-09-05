using System.Globalization;
using System.Xml.Linq;
using XFAForms.BaseDOM.Interfaces;
using XFAForms.Common;

namespace XFAForms.TemplateDOM.Interfaces
{
    public interface ITemplateDOM : IBaseDOM
    {

        void Initialize(XDPFile xdp, XDocument form);

        void ResolveExternalReferences();

    }
}