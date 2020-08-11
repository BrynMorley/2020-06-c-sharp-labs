using System;
using System.Xml;
using System.Xml.Linq;

namespace lab_41_xml
{
    class Program
    {
            static void Main(string[] args)
        {
            var xml01 = new XElement("test", 1);
            Console.WriteLine(xml01);

            var xml02 = new XElement("root",
                new XElement("level1",
                    new XAttribute("width",22),
                    new XElement("level2", 400),
                    new XElement("level2", 400)
                ),
                new XElement("level1",
                    new XAttribute("width", 33),
                    new XElement("level2", 400),
                    new XElement("level2", 400)
                ),
                new XElement("level1",
                    new XAttribute("width", 44),    
                    new XElement("level2", 400),
                    new XElement("level2", 400)
                )
             
                );
            Console.WriteLine(xml02);

            var doc02 = new XDocument(xml02);
            doc02.Save("XMLdoc02.xml");

            var readDoc02 = new XmlDocument();
            readDoc02.Load("XMLdoc02.xml");
            Console.WriteLine(readDoc02.InnerXml);
        }
    }
}
