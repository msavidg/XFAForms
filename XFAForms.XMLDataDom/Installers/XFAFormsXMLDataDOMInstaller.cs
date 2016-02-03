using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.XMLDataDom.Interfaces;

namespace XFAForms.XMLDataDOM.Installers
{
    public class XFAFormsXMLDataDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IXMLDataDOM>().ImplementedBy<XMLDataDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
