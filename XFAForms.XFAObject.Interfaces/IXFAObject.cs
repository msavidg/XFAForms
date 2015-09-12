using XFAForms.XFAObject.Interfaces.DataTypes;

namespace XFAForms.XFAObject.Interfaces
{
    public interface IXFAObject
    {
        DynamicDataXml record { get; set; }
        DynamicTemplateXml template { get; set; }
    }
}