using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.XFAObject.Interfaces;

namespace XFAForms.XFAObject.Installers
{
    public class XFAFormsTemplateDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IXFAObject>().ImplementedBy<XFAObject>().Configuration().LifestylePerWebRequest());
        }
    }
}
