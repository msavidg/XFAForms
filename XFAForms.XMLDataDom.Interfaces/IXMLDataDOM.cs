using System.Xml.Linq;
using XFAForms.BaseDOM.Interfaces;

namespace XFAForms.XMLDataDom.Interfaces
{

    /*
     * The XML Data DOM is a standard XML DOM that is used to hold the content of the XML data document. In
     * accordance with the W3C XML DOM specification [XMLDOM2] it has different types of nodes for elements,
     * attributes, and content. It does not distinguish properties from children nor does it ignore whitespace in
     * grouping elements. XFA processors do not in general operate directly on the XML Data DOM. Instead they
     * operate on the XFA Data DOM which presents and manipulates the same data in a more abstract way.
     * The XML Data DOM is always loaded from and/or written to XML. It has no other purpose. Unlike most
     * other DOMs, the XML Data DOM may operate in record mode. In this mode only global data plus a window
     * of record data is resident in memory at any moment.
     * 
     * Note: Throughout this specification when the term Data DOM is used without specifying the XML Data
     *       DOM or the XFA Data DOM, the XFA Data DOM is implied, not the XML Data DOM.
     * 
     */

    public interface IXMLDataDOM : IBaseDOM
    {

    }
}