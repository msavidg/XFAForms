using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

    public partial class Break : XFABaseElement
    {

        // <!--(DEPRECATED) An element that describes the constraints on moving to a new page or content area before or after rendering an object.-->

        private string _name = "break";
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

        public Break()
        {
            this._properties.Add("after",
                new XFAProperty()
                {
                    Name = "after",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"auto" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"contentArea" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"pageArea" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"pageEven" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"pageOdd" }
                    }
                }
            );

            // string
            this._properties.Add("afterTarget",
                new XFAProperty()
                {
                    Name = "afterTarget",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("before",
                new XFAProperty()
                {
                    Name = "before",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"auto" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"contentArea" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"pageArea" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"pageEven" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"pageOdd" }
                    }
                }
            );

            // string
            this._properties.Add("beforeTarget",
                new XFAProperty()
                {
                    Name = "beforeTarget",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("bookendLeader",
                new XFAProperty()
                {
                    Name = "bookendLeader",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("bookendTrailer",
                new XFAProperty()
                {
                    Name = "bookendTrailer",
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

            // string
            this._properties.Add("overflowLeader",
                new XFAProperty()
                {
                    Name = "overflowLeader",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("overflowTarget",
                new XFAProperty()
                {
                    Name = "overflowTarget",
                    Type = EnumXFAPropertyType.Property
                }
            );

            // string
            this._properties.Add("overflowTrailer",
                new XFAProperty()
                {
                    Name = "overflowTrailer",
                    Type = EnumXFAPropertyType.Property
                }
            );

            this._properties.Add("startNew",
                new XFAProperty()
                {
                    Name = "startNew",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = @"1" }
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
