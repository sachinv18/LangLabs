using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethodDemo;
namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "12.33";
            Console.WriteLine(str.MyToDouble());
            Console.ReadKey();

        }
    }
}
