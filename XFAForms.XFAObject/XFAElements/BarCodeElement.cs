using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Barcode : XFABaseElement
    {

        // <!--An element that represents a barcode.-->

        private string _name = "barcode";
        private Dictionary<string, IXFAProperty> _properties = new Dictionary<string, IXFAProperty>();
        private EnumXFAElementType _type = EnumXFAElementType.Content;
        
        public new string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public new Dictionary<string, IXFAProperty> Properties
        {
            get { return _properties; }
            set { _properties = value; }
        }

        public new EnumXFAElementType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Barcode()
        {
            // string
            this._properties.Add("charEncoding",
                new XFAProperty()
                {
                    Name = "charEncoding",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("checksum",
                new XFAProperty()
                {
                    Name = "checksum",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"1mod10" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"1mod10_1mod11" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"2mod10" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"auto" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"none" }
                    }
                }
            );

            // string
            this._properties.Add("dataColumnCount",
                new XFAProperty()
                {
                    Name = "dataColumnCount",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("dataLength",
                new XFAProperty()
                {
                    Name = "dataLength",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("dataPrep",
                new XFAProperty()
                {
                    Name = "dataPrep",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"flateCompress" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"none" }
                    }
                }
            );

            // string
            this._properties.Add("dataRowCount",
                new XFAProperty()
                {
                    Name = "dataRowCount",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("endChar",
                new XFAProperty()
                {
                    Name = "endChar",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("errorCorrectionLevel",
                new XFAProperty()
                {
                    Name = "errorCorrectionLevel",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // NCName
            this._properties.Add("id",
                new XFAProperty()
                {
                    Name = "id",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("moduleHeight",
                new XFAProperty()
                {
                    Name = "moduleHeight",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // measurementDataType
            this._properties.Add("moduleWidth",
                new XFAProperty()
                {
                    Name = "moduleWidth",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("printCheckDigit",
                new XFAProperty()
                {
                    Name = "printCheckDigit",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"1" }
                    }
                }
            );

            // string
            this._properties.Add("rowColumnRatio",
                new XFAProperty()
                {
                    Name = "rowColumnRatio",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("startChar",
                new XFAProperty()
                {
                    Name = "startChar",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("textLocation",
                new XFAProperty()
                {
                    Name = "textLocation",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"above" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"aboveEmbedded" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"below" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"belowEmbedded" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"none" }
                    }
                }
            );

            this._properties.Add("truncate",
                new XFAProperty()
                {
                    Name = "truncate",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"1" }
                    }
                }
            );

            // string
            this._properties.Add("type",
                new XFAProperty()
                {
                    Name = "type",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("upsMode",
                new XFAProperty()
                {
                    Name = "upsMode",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"internationalCarrier" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"secureSymbol" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"standardSymbol" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"usCarrier" }
                    }
                }
            );

            // string
            this._properties.Add("use",
                new XFAProperty()
                {
                    Name = "use",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("usehref",
                new XFAProperty()
                {
                    Name = "usehref",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("wideNarrowRatio",
                new XFAProperty()
                {
                    Name = "wideNarrowRatio",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("encrypt",
                new XFAProperty()
                {
                    Name = "encrypt",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
            this._properties.Add("extras",
                new XFAProperty()
                {
                    Name = "extras",
                    Type = EnumXFAPropertyType.StructuredProperty,
                    Values = new List<IXFAPropertyValue>()
                }
            );
        }
    }
}
