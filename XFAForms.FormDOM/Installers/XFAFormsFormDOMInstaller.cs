using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.FormDOM.Interfaces;

namespace XFAForms.FormDOM.Installers
{
    public class XFAFormsFormDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IFormDOM>().ImplementedBy<FormDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
