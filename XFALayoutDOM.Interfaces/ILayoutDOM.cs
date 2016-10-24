using XFAForms.BaseDOM.Interfaces;

namespace XFAForms.LayoutDOM.Interfaces
{

    /*
     * This internal DOM holds the result of laying out the form, including data, onto a page or pages. Each node
     * in the Layout DOM represents the placing of an object, or portion of an object, from the Form DOM into a
     * particular position on a particular page.
     * 
     * The Layout DOM is neither loaded from nor written to XML. It can always be reconstructed from the
     * template and the Form DOM so there is no need for it to persist.
     * 
     * The Layout DOM connects to the UI in interactive contexts but that connection is not defined in this
     * specification. except in very general terms. The Layout DOM also connects to the printer driver in
     * non-interactive contexts.
     * 
     */

    public interface ILayoutDOM : IBaseDOM
    {

    }
}