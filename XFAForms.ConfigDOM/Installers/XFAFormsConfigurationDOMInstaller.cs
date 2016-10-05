using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.ConfigurationDOM.Interfaces;

namespace XFAForms.ConfigurationDOM.Installers
{
    public class XFAFormsConfigurationDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IConfigurationDOM>().ImplementedBy<ConfigurationDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
