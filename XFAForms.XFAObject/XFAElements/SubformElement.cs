using System;
using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{
    public class SubformElement : XFABaseElement
    {
        private string _name = "subform";
        private Dictionary<string, IXFAProperty> _properties = new Dictionary<string, IXFAProperty>();
        private EnumXFAElementType _type = EnumXFAElementType.Content;

        public new string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public new Dictionary<string, IXFAProperty> Properties
        {
            get { return _properties; }
            private set { _properties = value; }
        }

        public new EnumXFAElementType Type
        {
            get { return _type; }
            private set { _type = value; }
        }

        public SubformElement()
        {

            // Properties

            this._properties.Add("allowMacro",
                new XFAProperty()
                {
                    Name = "allowMacro",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );

            this._properties.Add("anchorType",
                new XFAProperty()
                {
                    Name = "anchorType",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Value = "topLeft" },
                        new XFAPropertyValue() { Value = "topCenter" },
                        new XFAPropertyValue() { Value = "topRight" },
                        new XFAPropertyValue() { Value = "middleLeft" },
                        new XFAPropertyValue() { Value = "middleCenter" },
                        new XFAPropertyValue() { Value = "middleRight" },
                        new XFAPropertyValue() { Value = "bottomLeft" },
                        new XFAPropertyValue() { Value = "bottomCenter" },
                        new XFAPropertyValue() { Value = "bottomRight" }
                    }
                }
            );

            this._properties.Add("h",
                new XFAProperty()
                {
                    Name = "h",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Measurement, Value = "0", Unit = EnumXFAUnit.UnitInches}
                    }
                }
            );

            this._properties.Add("id",
                new XFAProperty()
                {
                    Name = "id",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                }
            );

            this._properties.Add("layout",
                new XFAProperty()
                {
                    Name = "layout",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Value = "position"},
                        new XFAPropertyValue() { Value = "lr-tb"},
                        new XFAPropertyValue() { Value = "rl-tb"},
                        new XFAPropertyValue() { Value = "tb"},
                        new XFAPropertyValue() { Value = "table"},
                        new XFAPropertyValue() { Value = "row"}
                    }
                }
            );

            this._properties.Add("maxH",
                new XFAProperty()
                {
                    Name = "maxH",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() {IsDefault = true,Type = EnumXFAPropertyValueType.Measurement, Value = "0", Unit = EnumXFAUnit.UnitInches}
                    }
                }
            );

            this._properties.Add("maxW",
                new XFAProperty()
                {
                    Name = "maxW",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() {IsDefault = true,Type = EnumXFAPropertyValueType.Measurement, Value = "0", Unit = EnumXFAUnit.UnitInches}
                    }
                }
            );

            this._properties.Add("minH",
                new XFAProperty()
                {
                    Name = "minH",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() {IsDefault = true,Type = EnumXFAPropertyValueType.Measurement, Value = "0", Unit = EnumXFAUnit.UnitInches}
                    }
                }
            );

            this._properties.Add("minW",
                new XFAProperty()
                {
                    Name = "minW",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() {IsDefault = true,Type = EnumXFAPropertyValueType.Measurement, Value = "0", Unit = EnumXFAUnit.UnitInches}
                    }
                }
            );

            this._properties.Add("name",
                new XFAProperty()
                {
                    Name = "name",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                }
            );

            this._properties.Add("presence",
                new XFAProperty()
                {
                    Name = "presence",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() {IsDefault = true, Value = "visible"},
                        new XFAPropertyValue() {Value = "invisible"},
                        new XFAPropertyValue() {Value = "hidden"}
                    }
                }
            );

            this._properties.Add("use",
                new XFAProperty()
                {
                    Name = "use",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                }
            );

            this._properties.Add("w",
                new XFAProperty()
                {
                    Name = "w",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() {IsDefault = true,Type = EnumXFAPropertyValueType.Measurement, Value = "0", Unit = EnumXFAUnit.UnitInches}
                    }
                }
            );

            this._properties.Add("x",
                new XFAProperty()
                {
                    Name = "x",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() {IsDefault = true,Type = EnumXFAPropertyValueType.Measurement, Value = "0", Unit = EnumXFAUnit.UnitInches}
                    }
                }
            );

            this._properties.Add("y",
                new XFAProperty()
                {
                    Name = "y",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() {IsDefault = true,Type = EnumXFAPropertyValueType.Measurement, Value = "0", Unit = EnumXFAUnit.UnitInches}
                    }
                }
            );

            // Structured Propertis

            this._properties.Add("border",
                new XFAProperty()
                {
                    Name = "border",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = 1,
                    MinOccurrence = 0
                }
            );

            this._properties.Add("desc",
                new XFAProperty()
                {
                    Name = "desc",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = 1,
                    MinOccurrence = 0
                }
            );

            this._properties.Add("extras",
                new XFAProperty()
                {
                    Name = "extras",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = 1,
                    MinOccurrence = 0
                }
            );

            this._properties.Add("margin",
                new XFAProperty()
                {
                    Name = "margin",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = 1,
                    MinOccurrence = 0
                }
            );

            this._properties.Add("occur",
                new XFAProperty()
                {
                    Name = "occur",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = 1,
                    MinOccurrence = 0
                }
            );

            this._properties.Add("para",
                new XFAProperty()
                {
                    Name = "para",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = 1,
                    MinOccurrence = 0
                }
            );

            this._properties.Add("validate",
                new XFAProperty()
                {
                    Name = "validate",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = 1,
                    MinOccurrence = 0
                }
            );

            // Children

            this._properties.Add("area",
                new XFAProperty()
                {
                    Name = "area",
                    Type = EnumXFAPropertyType.Child,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = null,
                    MinOccurrence = 0
                }
            );

            this._properties.Add("draw",
                new XFAProperty()
                {
                    Name = "draw",
                    Type = EnumXFAPropertyType.Child,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = null,
                    MinOccurrence = 0
                }
            );

            this._properties.Add("event",
                new XFAProperty()
                {
                    Name = "event",
                    Type = EnumXFAPropertyType.Child,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = null,
                    MinOccurrence = 0
                }
            );

            this._properties.Add("exclGroup",
                new XFAProperty()
                {
                    Name = "exclGroup",
                    Type = EnumXFAPropertyType.Child,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = null,
                    MinOccurrence = 0
                }
            );

            this._properties.Add("field",
                new XFAProperty()
                {
                    Name = "field",
                    Type = EnumXFAPropertyType.Child,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = null,
                    MinOccurrence = 0
                }
            );

            this._properties.Add("proto",
                new XFAProperty()
                {
                    Name = "proto",
                    Type = EnumXFAPropertyType.Child,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = null,
                    MinOccurrence = 0
                }
            );

            this._properties.Add("subform",
                new XFAProperty()
                {
                    Name = "subform",
                    Type = EnumXFAPropertyType.Child,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = null,
                    MinOccurrence = 0
                }
            );

            this._properties.Add("subformSet",
                new XFAProperty()
                {
                    Name = "subformSet",
                    Type = EnumXFAPropertyType.Child,
                    Values = new List<IXFAPropertyValue>(),
                    MaxOccurrence = null,
                    MinOccurrence = 0
                }
            );

        }
    }
}
