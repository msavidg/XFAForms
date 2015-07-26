using System;
using System.Xml.Linq;

namespace XFAForms.FormProcessor.Interfaces
{
    public interface IFormProcessor
    {
        Byte[] ProcessForm(XDocument formData, XDocument form);
    }
}