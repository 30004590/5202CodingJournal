using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean restart = true;
            do
            {


                int choice = 0;
                Console.WriteLine("===================================");
                Console.WriteLine("Please select which task to access ");
                Console.WriteLine("===================================");
                Console.WriteLine("1. 2. 3.");

                Console.WriteLine("Enter number here:");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        task1();
                        break;

                 
                    case 2:
                         task2();
                         break;

                    case 3:
                         task3();
                         break;


              

                }

                Console.WriteLine("\nDo You Want to run another task? Y/N");
                var check = Console.ReadLine().ToUpper();
                if (check == "N")
                {
                    restart = false;
                }
                Console.Clear();


                
            } while (restart);

            

        }


        public static void task1()
        {
            Console.Clear();
            Boolean restart = true ;
            do
            {
                Console.WriteLine("\nGuess My Favourite Animal");
                Console.WriteLine("Enter Here:");
                
                string userChoice = "";
                userChoice = Console.ReadLine().ToUpper();

                switch (userChoice)
                {
                    case "DOG":
                        Console.WriteLine("\nYou are correct");
                        restart = false;
                        break;

                    default:
                        Console.WriteLine("Animal is incorrect");
                        break;




                }

            } while (restart);



        }


        public static void task2()
        {
            Console.Clear();
            Boolean restart = true;
            do
            {
                Console.WriteLine("\nFruit Catalog");
                Console.WriteLine("\nPlease Enter Fruit Name For Pricing:");
                string fruitChoice = Console.ReadLine().ToUpper();
                    

                switch (fruitChoice)
                {
                    case "APPLE":
                        Console.WriteLine("\n#Apple     #$1.25 per kg");
                        break;

                    case "BANANA":
                        Console.WriteLine("\n#Banana     #$3.15 per kg");
                        break;

                    case "KIWIFRUIT":
                        Console.WriteLine("\n#Kiwifruit     #$4.65 per kg");
                        break;

                    case "ORANGE":
                        Console.WriteLine("\n#Orange     #$2.75 per kg");
                        break;

                    default:
                        Console.WriteLine("\nThat is either a vegetable or we dont have that product in stock");
                        break;

                }

                Console.WriteLine("\nDo You Want To See The Pricing For Another Fruit? Y/N");
                var check = Console.ReadLine().ToUpper();
                if (check == "N")
                {
                    restart = false;
                }

            } while (restart);



        }


        public static void task3()
        {
            
            Boolean restart = true;
            do
            {
                int x, y, result = 0;
                String @operator;
                Console.Clear();

                Console.WriteLine("Calculator");

                Console.WriteLine("\nEnter First Number:");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Operator to enter: +, -, *, /");
                @operator = Console.ReadLine();

                
                Console.WriteLine("\nEnter Second Number:");
                y = Convert.ToInt32(Console.ReadLine());

                switch (@operator)
                {
                    case "+":
                        result = x + y;
                        break;

                    case "-":
                        result = x - y;
                        break;

                    case "*":
                        result = x * y;
                        break;

                    case "/":
                        result = x / y;
                        break;

                    default:
                        Console.WriteLine("Error, please try again...");
                        break;
                }
                Console.Write("{0} {1} {2} = {3}", x, @operator, y, result);
                
                Console.WriteLine("\nDo You Wish To Calculate Again? Y/N");
                var check = Console.ReadLine().ToUpper();
                if (check == "N")
                {
                    restart = false;
                }

            } while (restart);



        }









    }
}
