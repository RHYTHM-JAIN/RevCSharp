using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevCSharp
{
    public static class RevInputs
    {
        public static void Inputs()
        {
            Console.Write("Enter your name => ");
            string? userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}!");

            Console.Read();
            Console.ReadKey();

            // all inputs are in form of string 
            //use these methods to verify

            if(string.IsNullOrEmpty(userName) ) { Console.WriteLine("NULL or Empty"); }

            // it can also be a whitespace to check that use this:
            if(string.IsNullOrWhiteSpace(userName) ) { Console.WriteLine("NULL or Empty or a WhiteSpace"); }
        }
    }
}
