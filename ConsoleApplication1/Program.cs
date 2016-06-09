using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            
            StringParser stringParser = new StringParser();
            Console.WriteLine(stringParser.getIsInitialized().ToString());

            Console.WriteLine(stringParser.Truncate("Esto es una cadena a truncar", 8));
            Console.WriteLine(stringParser.AdjustWith("Estosa es un prueba", 2));

            Console.WriteLine("Anothe line in the consle");
        }


    }

    
}
