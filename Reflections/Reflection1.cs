using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflections
{
    public class Reflection1
    {
        public static void Main(string[] args)
        {
            Type t = typeof(string);

            Console.WriteLine("Ujjwal :- {0}", t.Name);
            Console.WriteLine("Ujjwal Vishwakarma :- {0}", t.FullName);
            Console.WriteLine("Base Type :- {0}", t.BaseType);
        }
    }
}
