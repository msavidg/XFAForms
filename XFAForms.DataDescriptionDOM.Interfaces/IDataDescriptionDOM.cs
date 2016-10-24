using XFAForms.BaseDOM.Interfaces;

namespace XFAForms.DataDescriptionDOM.Interfaces
{

    /*
     * This DOM holds a schema for the data (as stored in the XFA Data DOM), and/or documents to be exchanged with web services.
     * The data description is mandatory if web services are being used, because it supplies the structure of the
     * documents to be exchanged with the web service. Otherwise it is optional.
     */

    public interface IDataDescriptionDOM : IBaseDOM
    {

    }
}