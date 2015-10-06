
using System.Collections.Generic;

namespace XFAForms.XFAObject.XFAElements
{

	public sealed class AnyElement : XFABaseElement
	{

		//

        private string _name = "AnyElement";
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

		public AnyElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class AppearanceFilterElement : XFABaseElement
	{

		//<!--An element that controls whether the document can be signed with a choice of named signature appearances.-->

        private string _name = "AppearanceFilterElement";
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

		public AppearanceFilterElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ArcElement : XFABaseElement
	{

		//<!--A curve that can be used for describing either an arc or an ellipse.-->

        private string _name = "ArcElement";
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

		public ArcElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class AreaElement : XFABaseElement
	{

		//<!--A container representing a geographical grouping of other containers.-->

        private string _name = "AreaElement";
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

		public AreaElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class AssistElement : XFABaseElement
	{

		//<!--An element that supplies additional information about a container for users of interactive applications.-->

        private string _name = "AssistElement";
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

		public AssistElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class BarcodeElement : XFABaseElement
	{

		//<!--An element that represents a barcode.-->

        private string _name = "BarcodeElement";
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

		public BarcodeElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class BindElement : XFABaseElement
	{

		//<!--An element that controls the behavior during merge operations of its enclosing element.-->

        private string _name = "BindElement";
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

		public BindElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class BindItemsElement : XFABaseElement
	{

		//<!--An element that extracts data into an item list.-->

        private string _name = "BindItemsElement";
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

		public BindItemsElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class BookendElement : XFABaseElement
	{

		//<!--An element controlling content that is inserted to "bookend" the contents of the parent object.-->

        private string _name = "BookendElement";
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

		public BookendElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class BooleanElement : XFABaseElement
	{

		//<!--A content element describing single unit of data content representing a Boolean logical value.-->

        private string _name = "BooleanElement";
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

		public BooleanElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class BorderElement : XFABaseElement
	{

		//<!--A box model element that describes the border surrounding an object.-->

        private string _name = "BorderElement";
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

		public BorderElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class BorderContent : XFABaseElement
	{

		//<!--A box model element that describes the border surrounding an object.-->

        private string _name = "BorderContent";
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

		public BorderContent()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class BreakElement : XFABaseElement
	{

		//<!--(DEPRECATED) An element that describes the constraints on moving to a new page or content area before or after rendering an object.-->

        private string _name = "BreakElement";
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

		public BreakElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class BreakAfterElement : XFABaseElement
	{

		//<!--An element that controls actions to be taken after laying down the contents of the parent object.-->

        private string _name = "BreakAfterElement";
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

		public BreakAfterElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class BreakBeforeElement : XFABaseElement
	{

		//<!--An element that controls actions to be taken before laying down the contents of the parent object.-->

        private string _name = "BreakBeforeElement";
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

		public BreakBeforeElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ButtonElement : XFABaseElement
	{

		//<!--A user interface element that describes a push-button widget.-->

        private string _name = "ButtonElement";
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

		public ButtonElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class CalculateElement : XFABaseElement
	{

		//<!--An automation element that controls the calculation of its container's value.-->

        private string _name = "CalculateElement";
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

		public CalculateElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class CaptionElement : XFABaseElement
	{

		//<!--A box model element that describes a descriptive label associated with an object.-->

        private string _name = "CaptionElement";
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

		public CaptionElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class CertificateElement : XFABaseElement
	{

		//<!--An element that holds a suitable Base64 DER-encoded X.509v3 certificate.-->

        private string _name = "CertificateElement";
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

		public CertificateElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class CertificatesElement : XFABaseElement
	{

		//<!--An element that holds a collection of certificate filters used to identify the signer.-->

        private string _name = "CertificatesElement";
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

		public CertificatesElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class CheckButtonElement : XFABaseElement
	{

		//<!--A user interface element that describes either a checkbox or radio-button widget.-->

        private string _name = "CheckButtonElement";
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

		public CheckButtonElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ChoiceListElement : XFABaseElement
	{

		//<!--A user interface element that describes a widget presenting a list of options. The list of options is specified by one or more sibling items elements.-->

        private string _name = "ChoiceListElement";
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

		public ChoiceListElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ColorElement : XFABaseElement
	{

		//<!--An element that describes a color.-->

        private string _name = "ColorElement";
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

		public ColorElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class CombElement : XFABaseElement
	{

		//<!--An element that causes a field to be presented with vertical lines between the character positions.-->

        private string _name = "CombElement";
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

		public CombElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ConnectElement : XFABaseElement
	{

		//<!--An element that describes the relationship between its containing object and a connection to a web service, schema, or data description. Connections are defined outside the template in a separate packet with its own schema. See the XFA Connection Set Specification for more information.-->

        private string _name = "ConnectElement";
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

		public ConnectElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ContentAreaElement : XFABaseElement
	{

		//<!--An element that describes a region within a page area eligible for receiving content.-->

        private string _name = "ContentAreaElement";
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

		public ContentAreaElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class CornerElement : XFABaseElement
	{

		//<!--A formatting element that describes the appearance of a vertex between two edges-->

        private string _name = "CornerElement";
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

		public CornerElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class DateElement : XFABaseElement
	{

		//<!--A content element that describes a single unit of data content representing a date.-->

        private string _name = "DateElement";
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

		public DateElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class DateTimeElement : XFABaseElement
	{

		//<!--A content element that describes a single unit of data content representing a date and time value.-->

        private string _name = "DateTimeElement";
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

		public DateTimeElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class DateTimeEditElement : XFABaseElement
	{

		//<!--A user interface element describing a widget intended to aid in the selection of date and/or time.-->

        private string _name = "DateTimeEditElement";
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

		public DateTimeEditElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class DecimalElement : XFABaseElement
	{

		//<!--A content type element that describes a single unit of data content representing a number with a fixed number of digits after the decimal.-->

        private string _name = "DecimalElement";
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

		public DecimalElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class DefaultUiElement : XFABaseElement
	{

		//<!--(DEPRECATED) An element for widgets whose depiction is delegated to the XFA application.-->

        private string _name = "DefaultUiElement";
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

		public DefaultUiElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class DescElement : XFABaseElement
	{

		//<!--An element to hold human-readable metadata.-->

        private string _name = "DescElement";
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

		public DescElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class DigestMethodElement : XFABaseElement
	{

		//<!--An element to hold the name of an acceptable digest method for a signature.-->

        private string _name = "DigestMethodElement";
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

		public DigestMethodElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class DigestMethodsElement : XFABaseElement
	{

		//<!--An element to hold a list of names of acceptable digest methods for a signature.-->

        private string _name = "DigestMethodsElement";
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

		public DigestMethodsElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class DrawElement : XFABaseElement
	{

		//<!--A container element that contains non-interactive data content.-->

        private string _name = "DrawElement";
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

		public DrawElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class EdgeElement : XFABaseElement
	{

		//<!--A formatting element that describes an arc, line, or one side of a border or rectangle.-->

        private string _name = "EdgeElement";
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

		public EdgeElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class EncodingElement : XFABaseElement
	{

		//<!--An element holding the name of an acceptable recipe for signature encoding.-->

        private string _name = "EncodingElement";
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

		public EncodingElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class EncodingsElement : XFABaseElement
	{

		//<!--An element holding a list of names of acceptable recipes for signature encoding.-->

        private string _name = "EncodingsElement";
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

		public EncodingsElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class EncryptElement : XFABaseElement
	{

		//<!--An element that controls encryption of barcode or submit data.-->

        private string _name = "EncryptElement";
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

		public EncryptElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class EncryptDataElement : XFABaseElement
	{

		//<!--An element that specifies instructions for an XML encryption or XML decryption operation.-->

        private string _name = "EncryptDataElement";
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

		public EncryptDataElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class EncryptionElement : XFABaseElement
	{

		//<!--This property specifies a collection of encryption certificates acceptable for an XML encryption operation.-->

        private string _name = "EncryptionElement";
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

		public EncryptionElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class EncryptionMethodElement : XFABaseElement
	{

		//<!--This property specifies a name of an encryption algorithm acceptable for an XML encryption operation.-->

        private string _name = "EncryptionMethodElement";
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

		public EncryptionMethodElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class EncryptionMethodsElement : XFABaseElement
	{

		//<!--This property specifies a collection of names of encryption algorithms acceptable for an XML encryption operation.-->

        private string _name = "EncryptionMethodsElement";
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

		public EncryptionMethodsElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class EventElement : XFABaseElement
	{

		//<!--An automation element that causes a script to be executed or data to be submitted whenever a particular event occurs.-->

        private string _name = "EventElement";
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

		public EventElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ExclGroupElement : XFABaseElement
	{

		//<!--A container element that describes a mutual exclusion relationship between a set of containers.-->

        private string _name = "ExclGroupElement";
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

		public ExclGroupElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ExDataElement : XFABaseElement
	{

		//<!--A content element that describes a single unit of data of a foreign datatype.-->

        private string _name = "ExDataElement";
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

		public ExDataElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ExecuteElement : XFABaseElement
	{

		//<!--An element that causes an event to invoke a WSDL-based web service.-->

        private string _name = "ExecuteElement";
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

		public ExecuteElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ExObjectElement : XFABaseElement
	{

		//<!--An element that describes a single program or implementation-dependent foreign object.-->

        private string _name = "ExObjectElement";
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

		public ExObjectElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ExtrasElement : XFABaseElement
	{

		//<!--An enclosure around one or more sets of custom properties. The content of this element may be used by custom applications.-->

        private string _name = "ExtrasElement";
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

		public ExtrasElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class FieldElement : XFABaseElement
	{

		//<!--A container element that describes a single interactive container capable of capturing and presenting data content.-->

        private string _name = "FieldElement";
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

		public FieldElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class FillElement : XFABaseElement
	{

		//<!--A formatting element that applies a color and optional rendered designs to the region enclosed by an object.-->

        private string _name = "FillElement";
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

		public FillElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class FilterElement : XFABaseElement
	{

		//<!--An element that contains the criteria for filtering signing certificates used to generate XML digital signatures.-->

        private string _name = "FilterElement";
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

		public FilterElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class FloatElement : XFABaseElement
	{

		//<!--A content element that describes a single unit of data content representing a floating point value.-->

        private string _name = "FloatElement";
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

		public FloatElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class FontElement : XFABaseElement
	{

		//<!--A formatting element that describes a font.-->

        private string _name = "FontElement";
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

		public FontElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class FormatElement : XFABaseElement
	{

		//<!--A rendering element that encloses output formatting information such as the picture clause.-->

        private string _name = "FormatElement";
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

		public FormatElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class HandlerElement : XFABaseElement
	{

		//<!--An element controlling what signature handler is used for a data-signing operation for an XML digital signature.-->

        private string _name = "HandlerElement";
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

		public HandlerElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class HyphenationElement : XFABaseElement
	{

		//<!--An element that controls auto-hyphenation of text.-->

        private string _name = "HyphenationElement";
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

		public HyphenationElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ImageElement : XFABaseElement
	{

		//<!--A content element that describes a single image.-->

        private string _name = "ImageElement";
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

		public ImageElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ImageEditElement : XFABaseElement
	{

		//<!--A user interface element that encloses a widget intended to aid in the manipulation of image content.-->

        private string _name = "ImageEditElement";
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

		public ImageEditElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class IntegerElement : XFABaseElement
	{

		//<!--A content element that describes a single unit of data content representing an integer value.-->

        private string _name = "IntegerElement";
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

		public IntegerElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class IssuersElement : XFABaseElement
	{

		//<!--A collection of issuer certificates that are acceptable for data signing an XML digital signature.-->

        private string _name = "IssuersElement";
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

		public IssuersElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ItemsElement : XFABaseElement
	{

		//<!--An element that supplies a set of values for a choice list or a check button.-->

        private string _name = "ItemsElement";
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

		public ItemsElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class KeepElement : XFABaseElement
	{

		//<!--An element that describes the constraints on keeping content together within a page or content area.-->

        private string _name = "KeepElement";
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

		public KeepElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class KeyUsageElement : XFABaseElement
	{

		//<!--An element that specifies the key usage settings required in the signing certificate.-->

        private string _name = "KeyUsageElement";
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

		public KeyUsageElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class LineElement : XFABaseElement
	{

		//<!--A content element that describes a single rendered line.-->

        private string _name = "LineElement";
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

		public LineElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class LinearElement : XFABaseElement
	{

		//<!--A fill type element that describes a linear gradient fill.-->

        private string _name = "LinearElement";
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

		public LinearElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class LockDocumentElement : XFABaseElement
	{

		//<!--An element that controls whether the document locks when it is signed.-->

        private string _name = "LockDocumentElement";
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

		public LockDocumentElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ManifestElement : XFABaseElement
	{

		//<!--An element that contains a list of references to all the nodes that are included in a node collection.-->

        private string _name = "ManifestElement";
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

		public ManifestElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class MarginElement : XFABaseElement
	{

		//<!--A box model element that specifies one or more insets for an object.-->

        private string _name = "MarginElement";
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

		public MarginElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class MdpElement : XFABaseElement
	{

		//<!--An element that controls an MDP+ signature.-->

        private string _name = "MdpElement";
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

		public MdpElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class MediumElement : XFABaseElement
	{

		//<!--An element that describes a physical medium upon which to render. Some hybrid paper/glass media, such as PDF, may require both paper and glass properties.-->

        private string _name = "MediumElement";
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

		public MediumElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class MessageElement : XFABaseElement
	{

		//<!--A automation element that holds one or more sub-elements containing messages used with validations and calculations.-->

        private string _name = "MessageElement";
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

		public MessageElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class NumericEditElement : XFABaseElement
	{

		//<!--A user interface element that describes a widget intended to aid in the manipulation of numeric content.-->

        private string _name = "NumericEditElement";
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

		public NumericEditElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class OccurElement : XFABaseElement
	{

		//<!--An element that describes the constraints over the number of allowable instances for its enclosing container.-->

        private string _name = "OccurElement";
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

		public OccurElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class OidElement : XFABaseElement
	{

		//<!--An Object Identifier (OID) of the certificate policies that must be present in the signing certificate.-->

        private string _name = "OidElement";
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

		public OidElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class OidsElement : XFABaseElement
	{

		//<!--A collection of Object Identifiers (OIDs) which apply to signing data with an XML digital signature.-->

        private string _name = "OidsElement";
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

		public OidsElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class OverflowElement : XFABaseElement
	{

		//<!--An element that controls what happens when the parent subform or subform set overflows the current layout container.-->

        private string _name = "OverflowElement";
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

		public OverflowElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class PageAreaElement : XFABaseElement
	{

		//<!--An element that describes a rendering surface.-->

        private string _name = "PageAreaElement";
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

		public PageAreaElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class PageSetElement : XFABaseElement
	{

		//<!--An element that describes a set of related page area objects.-->

        private string _name = "PageSetElement";
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

		public PageSetElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ParaElement : XFABaseElement
	{

		//<!--A formatting element that specifies default paragraph and alignment properties to be applied to the content of an enclosing container.-->

        private string _name = "ParaElement";
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

		public ParaElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class PasswordEditElement : XFABaseElement
	{

		//<!--A user interface element that describes a widget intended to aid in the manipulation of password content. Typically the user-interface will obscure any visual representation of the content.-->

        private string _name = "PasswordEditElement";
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

		public PasswordEditElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class PatternElement : XFABaseElement
	{

		//<!--A fill type element that describes a hatching pattern.-->

        private string _name = "PatternElement";
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

		public PatternElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class PictureElement : XFABaseElement
	{

		//<!--A rendering element that describes input parsing and output formatting information.-->

        private string _name = "PictureElement";
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

		public PictureElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ProtoElement : XFABaseElement
	{

		//<!--An element that describes a set of reusable element definitions, as described in the section Prototypes.-->

        private string _name = "ProtoElement";
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

		public ProtoElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class RadialElement : XFABaseElement
	{

		//<!--A fill type element that describes a radial gradient fill.-->

        private string _name = "RadialElement";
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

		public RadialElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ReasonElement : XFABaseElement
	{

		//<!--An element containing a candidate reason string for inclusion in an XML digital signature.-->

        private string _name = "ReasonElement";
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

		public ReasonElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ReasonsElement : XFABaseElement
	{

		//<!--An element containing a choice of reason strings for including with an XML Digital Signature.-->

        private string _name = "ReasonsElement";
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

		public ReasonsElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class RectangleElement : XFABaseElement
	{

		//<!--A content element that describes a single rendered rectangle.-->

        private string _name = "RectangleElement";
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

		public RectangleElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class RectangleContent : XFABaseElement
	{

		//<!--A content element that describes a single rendered rectangle.-->

        private string _name = "RectangleContent";
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

		public RectangleContent()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class RefElement : XFABaseElement
	{

		//<!--An element holding an XFA-SOM expression that identifies a node to be included in an XML digital signature.-->

        private string _name = "RefElement";
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

		public RefElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ScriptElement : XFABaseElement
	{

		//<!--An automation element that contains a script.-->

        private string _name = "ScriptElement";
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

		public ScriptElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class SetPropertyElement : XFABaseElement
	{

		//<!--An element that causes a property of the container to be copied from a value in the XFA Data DOM or from data returned by a web service.-->

        private string _name = "SetPropertyElement";
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

		public SetPropertyElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class SignatureElement : XFABaseElement
	{

		//<!--A user interface element that describes a widget intended to allow a user to sign a completed form, making it a document of record.-->

        private string _name = "SignatureElement";
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

		public SignatureElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class SignDataElement : XFABaseElement
	{

		//<!--An element controlling an XML digital signature.-->

        private string _name = "SignDataElement";
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

		public SignDataElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class SigningElement : XFABaseElement
	{

		//<!--A collection of signing certificates that are acceptable for use in affixing an XML digital signature.-->

        private string _name = "SigningElement";
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

		public SigningElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class SolidElement : XFABaseElement
	{

		//<!--A fill type element that describes a solid fill.-->

        private string _name = "SolidElement";
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

		public SolidElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class SpeakElement : XFABaseElement
	{

		//<!--An audible prompt describing the contents of a container. This element is ignored by non-interactive applications.-->

        private string _name = "SpeakElement";
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

		public SpeakElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class StippleElement : XFABaseElement
	{

		//<!--A fill type element that describes a stippling effect.-->

        private string _name = "StippleElement";
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

		public StippleElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class SubformElement : XFABaseElement
	{

		//<!--A container element that describes a single subform capable of enclosing other containers.-->

        private string _name = "SubformElement";
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

		public SubformElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class SubformSetElement : XFABaseElement
	{

		//<!--An element that describes a set of related subform objects.-->

        private string _name = "SubformSetElement";
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

		public SubformSetElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class SubjectDNElement : XFABaseElement
	{

		//<!--An element that contains a key-value pair used to specify the Subject Distinguished Name (DN) that must be present within the certificate for it to be acceptable for signing.-->

        private string _name = "SubjectDNElement";
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

		public SubjectDNElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class SubjectDNsElement : XFABaseElement
	{

		//<!--An element that contains the collection of key-value pairs used to specify the Subject Distinguished Name (DN) that must be present within the certificate for it to be acceptable for signing.-->

        private string _name = "SubjectDNsElement";
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

		public SubjectDNsElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class SubmitElement : XFABaseElement
	{

		//<!--An element that describes how to submit data to a host, using an HTTP POST operation.-->

        private string _name = "SubmitElement";
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

		public SubmitElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class TemplateElement : XFABaseElement
	{

		//<!--An element that describes a template. One such element exists for each template and all other elements described in this specification are descendants of the template element.-->

        private string _name = "TemplateElement";
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

		public TemplateElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class TextElement : XFABaseElement
	{

		//<!--A content element that describes a single unit of data content representing a plain textual value.-->

        private string _name = "TextElement";
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

		public TextElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class TextEditElement : XFABaseElement
	{

		//<!--A user interface element that encloses a widget intended to aid in the manipulation of textual content.-->

        private string _name = "TextEditElement";
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

		public TextEditElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class TimeElement : XFABaseElement
	{

		//<!--A content element that describes a single unit of data content representing a time value.-->

        private string _name = "TimeElement";
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

		public TimeElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class TimeStampElement : XFABaseElement
	{

		//<!--An element that controls the time-stamping of a signature.-->

        private string _name = "TimeStampElement";
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

		public TimeStampElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ToolTipElement : XFABaseElement
	{

		//<!--An element that supplies text for a tool tip. This element is ignored by non-interactive applications.-->

        private string _name = "ToolTipElement";
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

		public ToolTipElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class TraversalElement : XFABaseElement
	{

		//<!--An element that links its container to other objects in sequence.-->

        private string _name = "TraversalElement";
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

		public TraversalElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class TraverseElement : XFABaseElement
	{

		//<!--An element that declares a single link from its container to another object in a unidirectional chain of links.-->

        private string _name = "TraverseElement";
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

		public TraverseElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class UiElement : XFABaseElement
	{

		//<!--A user-interface element that encloses the actual user interface widget element.-->

        private string _name = "UiElement";
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

		public UiElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ValidateElement : XFABaseElement
	{

		//<!--A automation element that controls validation of user-supplied data.-->

        private string _name = "ValidateElement";
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

		public ValidateElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class ValueElement : XFABaseElement
	{

		//<!--A content element that encloses a single unit of data content.-->

        private string _name = "ValueElement";
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

		public ValueElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

	public sealed class VariablesElement : XFABaseElement
	{

		//<!--An element to hold document variables.-->

        private string _name = "VariablesElement";
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

		public VariablesElement()
		{
            this._properties.Add("circular",
                new XFAProperty()
                {
                    Name = "circular",
                    Type = EnumXFAPropertyType.Property,
                    Values = new List<IXFAPropertyValue>()
                    {
                        new XFAPropertyValue() { IsDefault = true, Type = EnumXFAPropertyValueType.Numeric, Value = "0" },
                        new XFAPropertyValue() { IsDefault = false, Type = EnumXFAPropertyValueType.Numeric, Value = "1" }
                    }
                }
            );
		}

	}

}