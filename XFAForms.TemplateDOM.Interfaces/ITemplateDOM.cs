using System.Globalization;
using System.Xml.Linq;
using XFAForms.BaseDOM.Interfaces;
using XFAForms.Common;
using XFAForms.XFAObject.Interfaces;

namespace XFAForms.TemplateDOM.Interfaces
{

    /*
     * This DOM holds the fixed components of the form. It controls the structure and organization of the form. It
     * supplies all the boilerplate. And it contains all the form’s intelligence, including scripts, defaults,
     * calculations, and validations.
     * 
     * The Template DOM is commonly loaded from and written to XML. No useful XFA processing can take place
     * without a template.
     * 
     */

    public interface ITemplateDOM : IBaseDOM
    {

        void Initialize(IXFAObject xfaObject, XDPFile xdp, XDocument form);

        void ResolveExternalReferences();

    }
}