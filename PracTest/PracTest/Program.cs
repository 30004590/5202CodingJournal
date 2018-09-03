using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracTest
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
                Console.WriteLine("1. 2. 3. 4.");

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

                    case 4:
                        task4();
                        break;

                    case 5:
                        task5();
                        break;


                    default:
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
            Console.WriteLine("Vowel Checker");


            Console.WriteLine("Enter a letter to see if it is a Vowel or Consonant");
            string UserLetter = (Console.ReadLine());

            switch (UserLetter)
            {
                case "a":
                case "e":
                case "o":
                case "u":
                    Console.WriteLine("{0} is a Vowel",UserLetter);
                    break;

                default:
                    Console.WriteLine("{0} is a Consonant");
                    break;

            }

            Console.WriteLine("Enter to close");
            Console.ReadLine();



        }


        public static void task2()
        {
            Console.WriteLine("Body Mass Calculator");
            Console.WriteLine("Please input your Height and Weight for BMI (Body Mass Index) calculation");
            Console.WriteLine("Enter Weight (Kg):");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height (cm):");
            float height = float.Parse(Console.ReadLine());


            height = height / 100;

            float BMI = weight / (height * height);
            Console.WriteLine("Your BMI is: {0}", BMI);

            Console.WriteLine("Enter to close");
            Console.ReadLine();


        }


        public static void task3()
        {
            Console.WriteLine("Loop Sum of Numbers");
            int userNum = 0, i = 1, total = 0;
            while (i != 20)
            {
                Console.Write("Enter number {0} for sum:",i);
                userNum = Convert.ToInt32(Console.ReadLine());
                total = total + userNum;

                i++;
            }

            Console.WriteLine("Total Sum: {0}", total);



        }


        public static void task4()
        {
            Console.WriteLine("Factorial");
            Console.WriteLine("This Program will produce the Factorial for 10:");
            int  i = 1, fact = 1;
            while (i <= 10)
            {
                fact = fact * i; 

                i++;
            }

            Console.WriteLine("The Factorial of 10: {0}", fact);

        }

        public static void task5()
        {
            



        }




    }
}
