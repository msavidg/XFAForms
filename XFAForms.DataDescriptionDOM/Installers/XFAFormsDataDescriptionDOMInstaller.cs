using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.DataDescriptionDOM.Interfaces;

namespace XFAForms.DataDescriptionDOM.Installers
{
    public class XFAFormsDataDescriptionDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IDataDescriptionDOM>().ImplementedBy<DataDescriptionDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
