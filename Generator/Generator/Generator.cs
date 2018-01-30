using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    class Generator
    {
        XmlCreator xmlCreator;
        Random random;
        FileWriter fileWriter;

        public Generator()
        {
            xmlCreator = new XmlCreator();
            random = new Random();
            fileWriter = new FileWriter();
        }

        public void Generate()
        {
            for(int entityId = ConstantData.startKey; entityId < ConstantData.numberOfRecords; entityId++)
            {
                var browser = GenerateBrowser();
                var xml = xmlCreator.CreateXml(ConstantData.startKey, ConstantData.system_key, ConstantData.person_key, GenerateIp(),
                    browser, GenerateBrowserVersion(browser), GenerateActionType(), DateToString(GenerateCreatedAt()));

                fileWriter.WriteToFile(xml);

                ConstantData.startKey++;
            }
            
        }

        public DateTime GenerateCreatedAt()
        {
            var year = ConstantData.year;
            var month = ConstantData.month;
            var day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);
            var hour = random.Next(0, 24);
            var minute = random.Next(0, 60);
            var second = random.Next(0, 60);
            return new DateTime(year, month, day, hour, minute, second);
        }

        public string DateToString(DateTime date)
        {
            return date.ToString("yyyy-MM-ddTHH:mm:ss.000");
        }

        public string GenerateIp()
        {
            var data = new byte[4];
            random.NextBytes(data);
            IPAddress ip = new IPAddress(data);
            return ip.ToString();
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
