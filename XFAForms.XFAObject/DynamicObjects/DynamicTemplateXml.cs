using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Xml.Linq;
using XFAForms.XFAObject.XFAElements;
using Attribute = System.Attribute;

namespace XFAForms.XFAObject.DynamicObjects

{

    public sealed class DynamicTemplateXml : DynamicObject, IEnumerable
    {

        private readonly Dictionary<string, IXFAElement> xfaElements = new Dictionary<string, IXFAElement>();

        private readonly List<XElement> _elements;

        public DynamicTemplateXml(string text)
        {

            var doc = XDocument.Parse(text);

            _elements = new List<XElement> { doc.Root };

            Initialize();
        }

        public DynamicTemplateXml(XElement element)
        {

            _elements = new List<XElement> { element };

            Initialize();

        }

        public DynamicTemplateXml(IEnumerable<XElement> elements)
        {

            _elements = new List<XElement>(elements);

            Initialize();

        }

        private void Initialize()
        {
            xfaElements.Add("appearanceFilter", new Appearancefilter());
            xfaElements.Add("arc", new Arc());
            xfaElements.Add("area", new Area());
            xfaElements.Add("assist", new Assist());
            xfaElements.Add("barcode", new Barcode());
            xfaElements.Add("bind", new Bind());
            xfaElements.Add("bindItems", new Binditems());
            xfaElements.Add("bookend", new Bookend());
            xfaElements.Add("boolean", new Boolean());
            xfaElements.Add("border", new Border());
            xfaElements.Add("break", new Break());
            xfaElements.Add("breakAfter", new Breakafter());
            xfaElements.Add("breakBefore", new Breakbefore());
            xfaElements.Add("button", new Button());
            xfaElements.Add("calculate", new Calculate());
            xfaElements.Add("caption", new Caption());
            xfaElements.Add("certificate", new Certificate());
            xfaElements.Add("certificates", new Certificates());
            xfaElements.Add("checkButton", new Checkbutton());
            xfaElements.Add("choiceList", new Choicelist());
            xfaElements.Add("color", new Color());
            xfaElements.Add("comb", new Comb());
            xfaElements.Add("connect", new Connect());
            xfaElements.Add("contentArea", new Contentarea());
            xfaElements.Add("corner", new Corner());
            xfaElements.Add("date", new Date());
            xfaElements.Add("dateTime", new Datetime());
            xfaElements.Add("dateTimeEdit", new Datetimeedit());
            xfaElements.Add("decimal", new Decimal());
            xfaElements.Add("defaultUi", new Defaultui());
            xfaElements.Add("desc", new Desc());
            xfaElements.Add("digestMethod", new Digestmethod());
            xfaElements.Add("digestMethods", new Digestmethods());
            xfaElements.Add("draw", new Draw());
            xfaElements.Add("edge", new Edge());
            xfaElements.Add("encoding", new Encoding());
            xfaElements.Add("encodings", new Encodings());
            xfaElements.Add("encrypt", new Encrypt());
            xfaElements.Add("encryptData", new Encryptdata());
            xfaElements.Add("encryption", new Encryption());
            xfaElements.Add("encryptionMethod", new Encryptionmethod());
            xfaElements.Add("encryptionMethods", new Encryptionmethods());
            xfaElements.Add("event", new Event());
            xfaElements.Add("exclGroup", new Exclgroup());
            xfaElements.Add("exData", new Exdata());
            xfaElements.Add("execute", new Execute());
            xfaElements.Add("exObject", new Exobject());
            xfaElements.Add("extras", new Extras());
            xfaElements.Add("field", new Field());
            xfaElements.Add("fill", new Fill());
            xfaElements.Add("filter", new Filter());
            xfaElements.Add("float", new Float());
            xfaElements.Add("font", new Font());
            xfaElements.Add("format", new Format());
            xfaElements.Add("handler", new Handler());
            xfaElements.Add("hyphenation", new Hyphenation());
            xfaElements.Add("image", new Image());
            xfaElements.Add("imageEdit", new Imageedit());
            xfaElements.Add("integer", new Integer());
            xfaElements.Add("issuers", new Issuers());
            xfaElements.Add("items", new Items());
            xfaElements.Add("keep", new Keep());
            xfaElements.Add("keyUsage", new Keyusage());
            xfaElements.Add("line", new Line());
            xfaElements.Add("linear", new Linear());
            xfaElements.Add("lockDocument", new Lockdocument());
            xfaElements.Add("manifest", new Manifest());
            xfaElements.Add("margin", new Margin());
            xfaElements.Add("mdp", new Mdp());
            xfaElements.Add("medium", new Medium());
            xfaElements.Add("message", new Message());
            xfaElements.Add("numericEdit", new Numericedit());
            xfaElements.Add("occur", new Occur());
            xfaElements.Add("oid", new Oid());
            xfaElements.Add("oids", new Oids());
            xfaElements.Add("overflow", new Overflow());
            xfaElements.Add("pageArea", new Pagearea());
            xfaElements.Add("pageSet", new Pageset());
            xfaElements.Add("para", new Para());
            xfaElements.Add("passwordEdit", new Passwordedit());
            xfaElements.Add("pattern", new Pattern());
            xfaElements.Add("picture", new Picture());
            xfaElements.Add("proto", new Proto());
            xfaElements.Add("radial", new Radial());
            xfaElements.Add("reason", new Reason());
            xfaElements.Add("reasons", new Reasons());
            xfaElements.Add("rectangle", new Rectangle());
            xfaElements.Add("ref", new Ref());
            xfaElements.Add("script", new Script());
            xfaElements.Add("setProperty", new Setproperty());
            xfaElements.Add("signature", new Signature());
            xfaElements.Add("signData", new Signdata());
            xfaElements.Add("signing", new Signing());
            xfaElements.Add("solid", new Solid());
            xfaElements.Add("speak", new Speak());
            xfaElements.Add("stipple", new Stipple());
            xfaElements.Add("subform", new Subform());
            xfaElements.Add("subformSet", new Subformset());
            xfaElements.Add("subjectDN", new Subjectdn());
            xfaElements.Add("subjectDNs", new Subjectdns());
            xfaElements.Add("submit", new Submit());
            xfaElements.Add("template", new Template());
            xfaElements.Add("text", new Text());
            xfaElements.Add("textEdit", new Textedit());
            xfaElements.Add("time", new Time());
            xfaElements.Add("timeStamp", new Timestamp());
            xfaElements.Add("toolTip", new Tooltip());
            xfaElements.Add("traversal", new Traversal());
            xfaElements.Add("traverse", new Traverse());
            xfaElements.Add("ui", new Ui());
            xfaElements.Add("validate", new Validate());
            xfaElements.Add("value", new Value());
            xfaElements.Add("variables", new Variables());
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {

            result = null;

            // Since template DOM is sparse we need to create a list for each element
            // If we have it in the XML, return the value of the attribute
            // If we don't have it in the XML, create it, add it to Attributes collection
            //var attr = _elements[0].Attribute(XName.Get(binder.Name));

            IXFAElement xfaElement = xfaElements[_elements[0].Name.LocalName];

            IXFAProperty property;

            if (_elements[0].HasAttributes && _elements[0].Attribute(binder.Name) != null)
            {
                result = _elements[0].Attribute(binder.Name).Value;
            }
            else if (xfaElement.Properties != null && xfaElement.Properties.TryGetValue(_elements[0].Name.LocalName, out property))
            {

                if (property.Type == EnumXFAPropertyType.Property)
                {

                    var a = new XAttribute(property.Name, property.Values.First(v => v.IsDefault == true).Value);

                    _elements[0].Add(a);

                    result = a.Value;
                }
            }

            if (result != null)
            {
                return true;
            }
            else
            {
                var items = _elements[0].Elements().Where(e => e.HasAttributes && e.Attribute("name").Value.Equals(binder.Name));

                if (items == null || items.Count() == 0)
                {
                    return false;
                }

                result = new DynamicTemplateXml(items);

                return true;
            }
        }

        public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
        {
            int ndx = (int)indexes[0];
            result = new DynamicTemplateXml(_elements[ndx]);

            return true;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var element in _elements)
                yield return new DynamicTemplateXml(element);
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {

            // Since template DOM is sparse we need to create a list for each element

            foreach (var element in _elements.Elements().Where(e => e.HasAttributes && e.Attribute("name") != null)) //This should really be restricted to child elements that are in the current element's structured properties
                yield return element.Attribute("name").Value;

            IXFAElement xfaElement = null;

            if (xfaElements.TryGetValue(_elements[0].Name.LocalName, out xfaElement))
            {

                if (xfaElement.Properties != null)
                {
                    foreach (var key in xfaElement.Properties.Keys)
                    {
                        yield return key;
                    }
                }
            }
        }

    }
}