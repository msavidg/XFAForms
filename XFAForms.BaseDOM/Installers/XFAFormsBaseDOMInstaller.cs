﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.BaseDOM.Interfaces;

namespace XFAForms.BaseDOM.Installers
{
    public class XFAFormsBaseDOMInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IBaseDOM>().ImplementedBy<BaseDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
