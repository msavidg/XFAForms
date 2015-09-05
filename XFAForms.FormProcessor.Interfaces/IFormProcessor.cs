using System;
using System.Xml.Linq;
using XFAForms.Common;

namespace XFAForms.FormProcessor.Interfaces
{
    public interface IFormProcessor
    {
        Byte[] ProcessForm(XDPFile xdp, XDocument formData, XDocument form);
    }
}