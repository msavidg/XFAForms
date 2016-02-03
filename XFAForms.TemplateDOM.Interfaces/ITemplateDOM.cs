using System.Globalization;
using System.Xml.Linq;
using XFAForms.BaseDOM.Interfaces;
using XFAForms.Common;
using XFAForms.XFAObject.Interfaces;

namespace XFAForms.TemplateDOM.Interfaces
{
    public interface ITemplateDOM : IBaseDOM
    {

        void Initialize(IXFAObject xfaObject, XDPFile xdp, XDocument form);

        void ResolveExternalReferences();

    }
}