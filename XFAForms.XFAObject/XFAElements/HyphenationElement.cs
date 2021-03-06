using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Hyphenation : XFABaseElement, IXFAElement
    {

        // <!--An element that controls auto-hyphenation of text.-->

        private string _name = "hyphenation";
        private Dictionary<string, IXFAProperty> _properties = new Dictionary<string, IXFAProperty>();
        private EnumXFAElementType _type = EnumXFAElementType.Content;
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Dictionary<string, IXFAProperty> Properties
        {
            get { return _properties; }
            set { _properties = value; }
        }

        public EnumXFAElementType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Hyphenation()
        {
            this._properties.Add("excludeAllCaps",
                new XFAProperty()
                {
                    Name = "excludeAllCaps",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"1" }
                    }
                }
            );

            this._properties.Add("excludeInitialCap",
                new XFAProperty()
                {
                    Name = "excludeInitialCap",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"1" }
                    }
                }
            );

            this._properties.Add("hyphenate",
                new XFAProperty()
                {
                    Name = "hyphenate",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"1" }
                    }
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

            // integerDataType
            this._properties.Add("pushCharacterCount",
                new XFAProperty()
                {
                    Name = "pushCharacterCount",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // integerDataType
            this._properties.Add("remainCharacterCount",
                new XFAProperty()
                {
                    Name = "remainCharacterCount",
                    Type = EnumXFAPropertyType.Property
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

            // integerDataType
            this._properties.Add("wordCharacterCount",
                new XFAProperty()
                {
                    Name = "wordCharacterCount",
                    Type = EnumXFAPropertyType.Property
                }
            );

        }
    }
}
