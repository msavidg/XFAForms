using Castle.Facilities.Logging;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using log4net.Config;

namespace XFAForms.Web.Installers
{
    public class LoggerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            XmlConfigurator.Configure();

            container.AddFacility<LoggingFacility>(f => f.UseLog4Net());

        }
    }
}