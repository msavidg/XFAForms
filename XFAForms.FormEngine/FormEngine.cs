using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Castle.Windsor;
using XFAForms.FormProcessor.Interfaces;
using XFAForms.TemplateDOM.Interfaces;

namespace XFAForms.FormEngine
{
    public class FormEngine
    {
        private readonly ILogger _logger;
        private readonly IFormProcessor _formProcessor;

        public FormEngine(ILogger logger, IFormProcessor formProcessor)
        {
            _logger = logger;
            _formProcessor = formProcessor;
        }

        public void Initialize()
        {
            _logger.Debug("Initialize!");
            _formProcessor.ProcessForm();
        }
    }
}
