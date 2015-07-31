using System.Xml.Linq;

namespace XFAForms.TemplateDOM.Interfaces
{
    public interface ITemplateDOM
    {

        void Initialize(XDocument form);
        void ResolveExternalReferences();

    }
}