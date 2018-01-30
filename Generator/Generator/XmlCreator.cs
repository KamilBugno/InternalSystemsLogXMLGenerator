using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generator
{
    class XmlCreator
    {
        public XDocument CreateXml(int _key, string system_key, string person_key, 
            string ip, string browser, string browserVersion, string action_type, string createdAt)
        {
            return new XDocument(
                new XElement("Root",
                    new XElement("_key", _key),
                    new XElement("system_key", system_key),
                    new XElement("person_key", person_key),
                    new XElement("network_data",
                        new XElement("ip", ip),
                        new XElement("browser", browser + "/" + browserVersion)),
                    new XElement("action_type", action_type),
                    new XElement("createdAt", createdAt)
                )
            );
        }
    }
}
