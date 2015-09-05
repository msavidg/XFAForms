using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace XFAForms.BaseDOM.Interfaces
{
    public interface IBaseDOM
    {
        void Initialize(XDocument form);

    }
}