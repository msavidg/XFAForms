using XFAForms.BaseDOM.Interfaces;

namespace XFAForms.FormDOM.Interfaces
{

    /*
     * This DOM holds the result of merging the data with the template. All nodes in the Form DOM are tied to
     * nodes representing form entities (such as fields or boilerplate) in the Template DOM. Some nodes in the
     * Form DOM are simultaneously tied to nodes representing data in the XFA Data DOM. Operations that
     * modify the value of a node in the Form DOM are passed through to the corresponding node in the XFA
     * Data DOM and vice-versa.
     * 
     * Caution: In the Adobe implementation the Form DOM is sparse. This means that properties and children
     * are not instantiated until they are used or needed. This has no effect upon the usual form
     * operations such as the user filling in a field, however it can be visible to scripts. In particular,
     * when a script retrieves a list of the children and properties of a node in the Form DOM, the list
     * only includes those nodes which have already been instantiated. For more information see the
     * description of the nodes property in [LC-Scripting-Reference].
     * 
     * The Form DOM is not necessarily loaded from or written to XML. However some XFA applications may
     * save a copy of all or part of the Form DOM in order to preserve the context of a session. This allows the
     * application to preserve:
     * 
     * ● data values that are not bound to any field.
     * ● the fact that the user has overridden the calculation of a field, so it should not be calculated upon reloading.
     * ● modifications made to the Form DOM by scripts, for example changing the border color of a field.
     * 
     * This specification does not define a syntax for saving the Form DOM in XML. One could save it using the
     * same schema used for XML representations of the Template DOM, however this would unnecessarily
     * duplicate a lot of information from the Template DOM.
     * The Form DOM is the natural territory of scripts because it is where logical entities assume values. For
     * example, when the user tabs into a field, the resulting field enter event is associated with a field object in
     * the Form DOM, not the Template DOM. When the script runs, the "$" or this variable points to the field
     * object in the Form DOM.
     * 
     */

    public interface IFormDOM : IBaseDOM
    {

    }
}