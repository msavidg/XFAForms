using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Microsoft.ClearScript.V8;
using XFAForms.Web.Controllers;

namespace XFAForms.Web.Plumbing
{
    public class DependencyConventions : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Component.For<V8ScriptEngine>().LifestyleSingleton());

            container.Install(FromAssembly.Named("XFAForms.FormEngine"));

            container.Register(Component.For<FormEngine.FormEngine>().LifestylePerWebRequest());

            container.Register(Component.For<FormsController>().LifestylePerWebRequest());

        }
    }
}