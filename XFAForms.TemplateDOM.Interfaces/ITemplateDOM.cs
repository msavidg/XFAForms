using System.Xml.Linq;
using XFAForms.BaseDOM.Interfaces;

namespace XFAForms.TemplateDOM.Interfaces
{
    public interface ITemplateDOM : IBaseDOM
    {

        void ResolveExternalReferences();

    }
}