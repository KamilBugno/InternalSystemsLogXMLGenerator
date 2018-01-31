using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generator
{
    class FileWriter
    {
        private string tag = "!#!";

        public void WriteToFile(XDocument xml)
        {
            File.AppendAllText(ConstantData.fileName, xml.ToString());
            File.AppendAllText(ConstantData.fileName, Environment.NewLine + tag + Environment.NewLine);
        }
    }
}
