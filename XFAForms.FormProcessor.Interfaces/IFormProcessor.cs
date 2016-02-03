using System;
using System.Xml.Linq;
using XFAForms.Common;

namespace XFAForms.FormProcessor.Interfaces
{
    public interface IFormProcessor
    {
        void Initialize(XDocument formData);

        Byte[] ProcessForm(XDPFile xdp, XDocument form);
    }
}