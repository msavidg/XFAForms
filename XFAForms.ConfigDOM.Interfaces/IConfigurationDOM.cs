using XFAForms.BaseDOM.Interfaces;

namespace XFAForms.ConfigurationDOM.Interfaces
{

    /*
     * This DOM holds option settings that modify the behavior of all the other DOMs. It may also hold private (custom) options.
     * Because it affects so many other things the Configuration DOM is the first one loaded by an XFA processor.
     * If a script modifies a value in the Configuration DOM there is often no immediate effect because the value
     * applies to processing which has already occurred.
     * A major part of the content of the Configuration DOM is a set of data transformation options used by the
     * XFA Data DOM. It is common to include the Configuration DOM in an XDP in order to ensure that
     * necessary transformations are carried out.
     */

    public interface IConfigurationDOM : IBaseDOM
    {

    }
}