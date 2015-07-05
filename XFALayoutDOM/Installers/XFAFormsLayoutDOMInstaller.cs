using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.XFALayoutDOM;
using XFALayoutDOM.Interfaces;

namespace XFALayoutDOM.Installers
{
    public class XFAFormsLayoutDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ILayoutDOM>().ImplementedBy<LayoutDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
