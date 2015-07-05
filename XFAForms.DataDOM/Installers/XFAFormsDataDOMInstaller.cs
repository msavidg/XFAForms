using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.DataDOM.Interfaces;

namespace XFAForms.DataDOM.Installers
{
    public class XFAFormsDataDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IXFADataDOM>().ImplementedBy<DataDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
