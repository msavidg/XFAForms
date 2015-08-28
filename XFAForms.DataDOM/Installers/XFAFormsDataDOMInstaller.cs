using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.XFADataDOM.Interfaces;

namespace XFAForms.XFADataDOM.Installers
{
    public class XFAFormsDataDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IXFADataDOM>().ImplementedBy<XFADataDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
