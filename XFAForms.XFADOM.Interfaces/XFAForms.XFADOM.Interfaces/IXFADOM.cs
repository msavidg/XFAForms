using XFAForms.BaseDOM.Interfaces;

namespace XFAForms.XFADOM.Interfaces
{
    /*
     * The XFA DOM is a wrapper for the other DOMs. In addition it has a few nodes of its own, for example the
     * host object ($host) which holds a number of convenience methods for scripts.
     * 
     * The XFA DOM is not directly loaded from or written to XML, but some of the DOMs within it are. Within an
     * XFA application the XFA DOM always exists, even when none of the other DOMs do (for example, at the
     * start of processing).
     * 
     */

    public interface IXFADOM : IBaseDOM
    {
    }
}