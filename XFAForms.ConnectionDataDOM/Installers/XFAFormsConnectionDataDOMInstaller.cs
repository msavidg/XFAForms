using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.ConnectionDataDOM.Interfaces;

namespace XFAForms.ConnectionDataDOM.Installers
{
    public class XFAFormsConnectionDataDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IConnectionDataDOM>().ImplementedBy<ConnectionDataDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
