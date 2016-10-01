using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.LocaleSetDOM.Interfaces;

namespace XFAForms.LocaleSetDOM.Installers
{
    public class XFAFormsLocaleSetDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ILocaleSetDOM>().ImplementedBy<LocaleSetDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
