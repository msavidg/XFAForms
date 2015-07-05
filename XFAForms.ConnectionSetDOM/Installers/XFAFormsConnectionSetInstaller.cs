﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XFAForms.ConnectionSetDOM.Interfaces;

namespace XFAForms.ConnectionSetDOM.Installers
{
    public class XFAFormsConnectionSetInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IConnectionSetDOM>().ImplementedBy<ConnectionSetDOM>().Configuration().LifestylePerWebRequest());
        }
    }
}
