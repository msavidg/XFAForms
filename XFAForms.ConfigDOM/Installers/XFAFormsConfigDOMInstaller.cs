using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.ConfigDOM.Interfaces;

namespace XFAForms.ConfigDOM.Installers
{
    public class XFAFormsConfigDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IConfigDOM>().ImplementedBy<ConfigDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
