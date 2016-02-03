
using System.Dynamic;

namespace XFAForms.XFAObject.Interfaces
{
    public interface IXFAObject
    {

        DynamicObject record { get; set; }

        DynamicObject template { get; set; }

    }
}