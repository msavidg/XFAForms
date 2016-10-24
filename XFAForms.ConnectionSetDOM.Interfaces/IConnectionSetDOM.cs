using XFAForms.BaseDOM.Interfaces;

namespace XFAForms.ConnectionSetDOM.Interfaces
{

    /*
     * This DOM holds information concerning web services using WSDL, such as the URL at which the service is located.
     * The Connection Set DOM names each transaction it describes. The transaction names are used to
     * associate the transactions with events that activate the transactions. Hence this DOM is mandatory if the
     * form uses web services. It is otherwise optional.
     * 
     * This DOM is commonly loaded from and/or written to an XDP.
     * 
     */

    public interface IConnectionSetDOM : IBaseDOM
    {

    }
}