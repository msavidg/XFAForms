using System;
using System.Xml.Linq;
using XFAForms.BaseDOM.Interfaces;
using XFAForms.XFAObject.Interfaces;

namespace XFAForms.XFADataDOM.Interfaces
{
    public interface IXFADataDOM : IBaseDOM
    {
        void Initialize(IXFAObject xfaObject, XDocument form);

    }
}