using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XFAForms.XFAObject.DynamicObjects;

namespace XFAForms.Tests
{
    [TestClass]
    public class DynamicXmlTests
    {

        XNamespace xdp = "http://ns.adobe.com/xdp/";
        XNamespace xfa_template = "http://www.xfa.org/schema/xfa-template/2.6/";
        XNamespace xci = "http://www.xfa.org/schema/xci/2.6/";
        XNamespace xfa_locale_set = "http://www.xfa.org/schema/xfa-locale-set/2.6/";
        XNamespace x = "adobe:ns:meta/";

        private XDocument sample = null;

        [TestInitialize]
        public void Setup()
        {

            sample = new XDocument(
                new XElement(xdp + "xdp", new object[]
                    {
                        new XAttribute(XNamespace.Xmlns + "xdp", xdp.ToString()),
                        new XAttribute("timeStamp", DateTime.Now.ToString("O")),
                        new XAttribute("uuid", Guid.NewGuid()),
                            new XElement(xfa_template + "template",
                                new XElement("subform", new object[]
                                {
                                    new XAttribute("name","form1"),
                                    new XAttribute("layout","tb"),
                                    new XAttribute("locale","en_US"),
                                    new XAttribute("restoreState","auto"),
                                    new XElement("pageSet",
                                        new XElement("pageArea", new object []
                                        {
                                            new XAttribute("name", "page1")
                                        })
                                    ),
                                })),
                            new XElement(xci + "config"),
                            new XElement(xfa_locale_set + "localeSet"),
                            new XElement(x+"xmpmeta", new object []
                            {
                                new XAttribute(XNamespace.Xmlns + "x", x.ToString()),
                                new XAttribute(x + "xmptk", "Adobe XMP Core 4.2.1-c041 52.337767, 2008/04/13-15:41:00        ")
                            }),
                    })
            );

        }

        [TestMethod]
        public void Basic()
        {
            dynamic dtx = new DynamicTemplateXml(sample.Descendants().First(d => d.Name.LocalName == "template").ToString());
            IEnumerable<string> s = dtx.GetDynamicMemberNames();
            Assert.IsTrue(s.Contains("form1"));

            dynamic a = dtx.form1;
            s = a.GetDynamicMemberNames();
            Assert.IsTrue(s.Contains("pageArea"));
        }
    }
}