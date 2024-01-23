using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevCSharp
{
    public static class RevOutputs
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");

            int a = 1;
            int b = 2;

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);

            Console.WriteLine($"{a} + {b} = {a+b}");

            Console.Write("Enter Age => ");
        }
    }
}
