using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generator
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Generator generator = new Generator();
            generator.Generate();
            Console.ReadKey();
        }
    }
}
