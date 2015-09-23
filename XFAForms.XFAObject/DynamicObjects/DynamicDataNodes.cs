using System.Collections;
using System.Collections.Generic;
using System.Dynamic;

namespace XFAForms.XFAObject.DynamicObjects
{
    public sealed class DynamicDataNodes : DynamicObject, IEnumerable
    {

        private readonly List<DynamicDataXml> _nodes;

        public DynamicDataNodes(List<DynamicDataXml> nodes)
        {
            _nodes = nodes;
        }

        public int length
        {
            get { return _nodes.Count; }
        }

        public DynamicDataXml item(int index)
        {
            return _nodes[index];
        }

        public IEnumerator GetEnumerator()
        {

            return _nodes.GetEnumerator();

        }

    }
}
