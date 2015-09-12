using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFAForms.TemplateDOM.DataTypes
{
    public sealed class DynamicTemplateNodes : DynamicObject, IEnumerable
    {

        private readonly List<DynamicTemplateXml> _nodes;

        public DynamicTemplateNodes(List<DynamicTemplateXml> nodes)
        {
            _nodes = nodes;
        }

        public int length
        {
            get { return _nodes.Count; }
        }

        public DynamicTemplateXml item(int index)
        {
            return _nodes[index];
        }

        public IEnumerator GetEnumerator()
        {

            return _nodes.GetEnumerator();

        }

    }
}
