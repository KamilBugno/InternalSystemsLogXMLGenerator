using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    class Generator
    {
        XmlCreator xmlCreator;
        Random random;

        public Generator()
        {
            xmlCreator = new XmlCreator();
            random = new Random();
        }

        public void Generate()
        {
            var browser = GenerateBrowser();
            var xml = xmlCreator.CreateXml(ConstantData.startKey, ConstantData.system_key, ConstantData.person_key, GenerateIp(),
                browser, GenerateBrowserVersion(browser), GenerateActionType(), GenerateCreatedAt());
            Console.WriteLine(xml);
        }

        public string GenerateCreatedAt()
        {
            return String.Empty;
        }

        public string GenerateIp()
        {
            return String.Empty;
        }

        public string GenerateBrowser()
        {
            var browserId = random.Next(0, ConstantData.browser.Length);
            return ConstantData.browser[browserId];
        }

        public string GenerateBrowserVersion(string browser)
        {
            return ChooseRandomlyFromList(ConstantData.browserVersion[browser]);
        }

        public string GenerateActionType()
        {
            var actionTypeId = random.Next(0, ConstantData.action_type.Length);
            return ConstantData.action_type[actionTypeId];
        }

        private string ChooseRandomlyFromList(string[] list)
        {
            var maxValue = list.Length;
            var randomNumber = random.Next(0, maxValue);
            return list[randomNumber];
        }
    }
}
