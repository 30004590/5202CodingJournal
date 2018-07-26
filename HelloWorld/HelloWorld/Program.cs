using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable method for console output
            string output = "Hello World";
            Console.WriteLine(output);

            //used for blank space
            Console.WriteLine();
            //can also use \n e.g "hello world \n"

            
            //one line output method
            Console.WriteLine("Hello World");

            //storing and outputing string name
            string name = "";
            Console.WriteLine("Please type in name:");
            name = Console.ReadLine();
            Console.WriteLine("\nHello {0}", name);
            Console.WriteLine();



            //basic calculation
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("===========================:");
            Console.WriteLine("==========Addition=========:");
            Console.WriteLine("===========================:");
            Console.WriteLine("Please type in first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type in second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            int ans = num1 + num2;
            Console.WriteLine("\n{0} + {1} = {2}",num1, num2, ans);





            Console.WriteLine();
            Console.WriteLine("press enter to close program");
            Console.ReadLine();

        }
    }
}
