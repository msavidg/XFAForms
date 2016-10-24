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

        private readonly XNamespace _xdp = "http://ns.adobe.com/xdp/";
        private readonly XNamespace _xfaTemplate = "http://www.xfa.org/schema/xfa-template/2.6/";
        private readonly XNamespace _xci = "http://www.xfa.org/schema/xci/2.6/";
        private readonly XNamespace _xfaLocaleSet = "http://www.xfa.org/schema/xfa-locale-set/2.6/";
        private readonly XNamespace _x = "adobe:ns:meta/";

        private XDocument sample = null;

        //[TestInitialize]
        public void Setup()
        {

            sample = new XDocument(
                new XElement(_xdp + "xdp", new object[]
                    {
                        new XAttribute(XNamespace.Xmlns + "xdp", _xdp.ToString()),
                        new XAttribute("timeStamp", DateTime.Now.ToString("O")),
                        new XAttribute("uuid", Guid.NewGuid()),
                            new XElement(_xfaTemplate + "template",
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
                            new XElement(_xci + "config"),
                            new XElement(_xfaLocaleSet + "localeSet"),
                            new XElement(_x+"xmpmeta", new object []
                            {
                                new XAttribute(XNamespace.Xmlns + "x", _x.ToString()),
                                new XAttribute(_x + "xmptk", "Adobe XMP Core 4.2.1-c041 52.337767, 2008/04/13-15:41:00        ")
                            }),
                    })
            );

        }

        //[TestMethod]
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