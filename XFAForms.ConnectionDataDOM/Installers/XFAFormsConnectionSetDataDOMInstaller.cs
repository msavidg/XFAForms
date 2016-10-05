using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.ConnectionSetDataDOM.Interfaces;

namespace XFAForms.ConnectionSetDataDOM.Installers
{
    public class XFAFormsConnectionSetDataDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IConnectionSetDataDOM>().ImplementedBy<ConnectionSetDataDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
