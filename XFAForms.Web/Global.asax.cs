using System.Web.Http;
using System.Web.Http.Dispatcher;
using Castle.Facilities.Logging;
using Castle.Windsor;
using XFAForms.Web.Plumbing;

namespace XFAForms.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {

        private readonly IWindsorContainer _container;

        public WebApiApplication()
        {
            this._container = new WindsorContainer().Install(new DependencyConventions());
            _container.AddFacility<LoggingFacility>(f => f.LogUsing(LoggerImplementation.Log4net).WithAppConfig());
        }

        protected void Application_Start()
        {

            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), new WindsorControllerFactory(this._container));

        }

        public override void Dispose()
        {
            this._container.Dispose();
            base.Dispose();
        }
    }
}
