using System;
using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public enum EnumXFAElementType
    {
        Container,  // Draw, Field, Area, Subform, Exclusion Group, Template, and Container Value
        Content     // Arc, Boolean, Date, DateTime, Deciaml, ExData, Float, Image, Integer, Line, Rectangle, Text, and Time
    }

    public enum EnumXFAPropertyType
    {
        Property,
        StructuredProperty,
        MutuallyExclusiveStructuredProperty,
        Child
    };

    public enum EnumXFAPropertyValueType
    {
        Measurement,    // 2in
        Numeric,        // 2
        String          // hidden
    };

    public enum EnumXFAUnit
    {
        UnitNone,           // no unit
        UnitCentimeters,    // centimeters
        UnitInches,         // inches
        UnitMillimeters,    // millimeters
        UnitPoints          // points
    }

    public interface IXFAElement
    {

        // Properties
        // Structured Properties
        // Mutually Exclusive Structured Properties
        // Children

        string Name { get; set; }

        Dictionary<string, IXFAProperty> Properties { get; set; }

        EnumXFAElementType Type { get; set; }

        List<String> Children { get; set; }

    }

    public interface IXFAProperty
    {

        string Name { get; set; }

        EnumXFAPropertyType Type { get; set; }

        List<IXFAPropertyValue> Values { get; set; }

        int? MinOccurrence { get; set; }

        int? MaxOccurrence { get; set; }

    }

    public interface IXFAPropertyValue
    {

        EnumXFAPropertyValueType Type { get; set; }

        string Value { get; set; }

        bool IsDefault { get; set; }

    }

    public interface IXFAMeasurement
    {

        EnumXFAUnit Unit { get; set; }

        string ToCentimeters();

        string ToInches();

        string ToMillimeters();

        string ToPoints();

    }
}