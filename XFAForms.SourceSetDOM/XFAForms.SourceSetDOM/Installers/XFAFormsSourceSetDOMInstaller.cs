using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.SourceSetDOM.Interfaces;

namespace XFAForms.SourceSetDOM.Installers
{
    public class XFAFormsSourceSetDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ISourceSetDOM>().ImplementedBy<SourceSetDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
