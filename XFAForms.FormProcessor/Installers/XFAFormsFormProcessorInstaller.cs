using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using XFAForms.FormProcessor.Interfaces;

namespace XFAForms.FormProcessor.Installers
{
    public class XFAFormsFormProcessorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Install(FromAssembly.Named("XFAForms.BaseDOM"));
            container.Install(FromAssembly.Named("XFAForms.ConfigDOM"));
            container.Install(FromAssembly.Named("XFAForms.ConnectionDataDOM"));
            container.Install(FromAssembly.Named("XFAForms.ConnectionSetDOM"));
            container.Install(FromAssembly.Named("XFAForms.DataDescriptionDOM"));
            container.Install(FromAssembly.Named("XFAForms.FormDOM"));
            container.Install(FromAssembly.Named("XFAForms.LayoutDOM"));
            container.Install(FromAssembly.Named("XFAForms.TemplateDOM"));
            container.Install(FromAssembly.Named("XFAForms.XFADataDOM"));
            container.Install(FromAssembly.Named("XFAForms.XMLDataDOM"));

            container.Register(Component.For<IFormProcessor>().ImplementedBy<FormProcessor>().Configuration().LifestylePerWebRequest());

        }
    }
}
