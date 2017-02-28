using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4_BuiltInStringType
{
    class Program
    {
        static void Main()
        {
            string Name = "\"My name is\n John\n Doe.\n\""; //escape sequences
            Console.WriteLine(Name);

            string path = @"C:\MyComputer\DeskTop"; //verbatim literal @, prints all chars
            Console.WriteLine(path);

            Console.ReadLine();
        }
    }
}
