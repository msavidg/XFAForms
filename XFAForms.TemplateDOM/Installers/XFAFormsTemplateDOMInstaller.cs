using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.TemplateDOM.Interfaces;

namespace XFAForms.TemplateDOM.Installers
{
    public class XFAFormsTemplateDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ITemplateDOM>().ImplementedBy<TemplateDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
