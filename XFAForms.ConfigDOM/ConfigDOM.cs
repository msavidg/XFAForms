﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using XFAForms.BaseDOM.Interfaces;
using XFAForms.ConfigDOM.Interfaces;

namespace XFAForms.ConfigDOM
{
    public class ConfigDOM : BaseDOM.BaseDOM, IConfigDOM
    {
        private readonly ILogger _logger;

        public ConfigDOM(ILogger logger)
            : base(logger)
        {
            _logger = logger;
        }
    }
}