using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter;

namespace XFAForms.TemplateDOM.Elements
{

    public sealed class Attribute
    {
        public Attribute()
        {
            this.Values = new List<AttributeValue>();
        }

        public string Name { get; set; }

        public List<AttributeValue> Values { get; set; }
    }

}
