using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.LayoutDOM.Interfaces;

namespace XFAForms.LayoutDOM.Installers
{
    public class XFAFormsLayoutDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ILayoutDOM>().ImplementedBy<LayoutDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
