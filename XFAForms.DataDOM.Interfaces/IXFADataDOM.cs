using System;
using System.Xml.Linq;
using XFAForms.BaseDOM.Interfaces;
using XFAForms.XFAObject.Interfaces;

namespace XFAForms.XFADataDOM.Interfaces
{

    /*
     * The XFA Data DOM presents an abstract view of the XML data document. In this abstract view the
     * document contents are represented by two types of nodes, data group nodes and data value nodes. Data
     * group nodes represent grouping elements. Data value nodes represent non-grouping elements and
     * attributes.
     * 
     * There are property nodes in the XFA Data DOM. However usually these do not represent elements or
     * attributes in the XML data document. Rather they hold properties associated with an element or attribute.
     * For example, each node has a name property which holds the start tag of the element or the name of the
     * attribute. Similarly there is namespace property which holds the full namespace of the element or
     * attribute, regardless of whether it was inherited or declared explicitly. Sometimes a property node does
     * correspond to a particular attribute but in such cases the attribute is in a reserved namespace and is
     * treated as out-of-band information. For example, the xsi:nil attribute defined by [XML-Schema] in the
     * namespace http://www.w3.org/2001/XMLSchema-instance is not represented in the XFA Data
     * DOM as a data value node. Instead it modifies the isNull property of the data value node corresponding
     * to the element which holds it.
     * 
     * There are a large number of options available to transform the data on its way in from the XML Data DOM
     * to the XFA Data DOM. In most cases the reverse transform is applied on the way out. Hence scripts which
     * operate on the XFA Data DOM can be isolated from details of the XML representation. For example, it is
     * possible to rename particular elements or attributes on the way in. When the data is subsequently written
     * out to a new XML document the original element tags appear in the new document.
     * 
     * The XFA Data DOM is not directly loaded from or written to XML. However its content is echoed in the XML
     * Data DOM which is always loaded from and/or written to XML. Unlike most other DOMs, the XFA Data
     * DOM may operate in record mode. In this mode only global data plus a window of record data is resident
     * in memory at any moment.
     * 
     * Note: Throughout this specification when the term Data DOM is used without specifying the XML Data
     *       DOM or the XFA Data DOM, the XFA Data DOM is implied.
     * 
     */

    public interface IXFADataDOM : IBaseDOM
    {
        void Initialize(IXFAObject xfaObject, XDocument form);

    }
}