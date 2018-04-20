using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    public static class StringExtensions
    {
        public static double MyToDouble (this string data)
        {
        
            return Double.Parse(data);
            
        }
    }
}
