using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.XFADOM.Interfaces;

namespace XFAForms.XFADOM.Installers
{
    public class XFAFormsXFADOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IXFADOM>().ImplementedBy<XFADOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
