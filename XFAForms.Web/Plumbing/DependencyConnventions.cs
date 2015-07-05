using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using XFAForms.Web.Controllers;

namespace XFAForms.Web.Plumbing
{
    public class DependencyConnventions : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Install(FromAssembly.Named("XFAForms.FormEngine"));

            container.Register(Component.For<FormEngine.FormEngine>().LifestylePerWebRequest());

            container.Register(Component.For<FormsController>().LifestylePerWebRequest());

        }
    }
}