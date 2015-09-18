using System;
using System.Collections.Generic;

namespace XFAForms.TemplateDOM.Elements
{
    public interface IElement
    {

        string Name { get; set; }

        List<Attribute> Attributes { get; set; }

        List<String> Children { get; set; }

    }
}