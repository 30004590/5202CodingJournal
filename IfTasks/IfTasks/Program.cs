using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean restart = true;

            /*Boolean restart = true;
            do
            {
                restart = false;
            } while (restart); 
            */


            do
            {

                int choice = 0;
                Console.WriteLine("===================================");
                Console.WriteLine("Please select which task to access ");
                Console.WriteLine("===================================");
                Console.WriteLine("1. 2. 3. 4. 5. 6.");

                Console.WriteLine("Enter number here:");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    task1();

                }

                else if (choice == 2)
                {
                    task2();
                }

                else if(choice == 3)
                {
                    task3();
                }

                else if (choice == 4)
                {
                    task4();
                }

                else if (choice == 5)
                {
                    task5();
                }

                else
                {
                    task6();
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
            int num1 = 0, num2 = 0;


            Console.WriteLine("\nPlease Enter First Number:");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease Enter Second Number:");
            num2 = Int32.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("\n{0} is equal to {1}", num1, num2);

            }
            else if (num1 > num2)
            {
                Console.WriteLine("\n{0} is greater than {1}", num1, num2);

            }
            else
            {
                Console.WriteLine("\n{0} is less than {1}", num1, num2);

            }
            

            //{0:0.0}
        }

        public static void task2()
        {
            int myNum = 6, userNum = 0;

            Console.WriteLine("Guess My Number");
            while (myNum != userNum)
            {

                userNum = 0;
                Console.WriteLine("\nEnter Number:");
                userNum = Int32.Parse(Console.ReadLine());

                if (userNum == myNum)
                {
                    Console.WriteLine("Correct, you win");

                }
                else if (userNum > myNum)
                {
                    Console.WriteLine("Sorry that is higher than the number");

                }
                else
                {
                    Console.WriteLine("Sorry that is lower than the number");

                }

            }

            

        }

        public static void task3()
        {
            Boolean restart = true;
            int grade = 0;
            Console.WriteLine("=====Grades=====");


            do {
                Console.WriteLine("\nPlease Enter final score:");
                grade = 0;
                grade = Int32.Parse(Console.ReadLine());



                if (grade > 100)
                {
                    Console.WriteLine("\nWarning {0} is larger than maximum", grade);
                    
                }

                else if (grade < 0)
                {
                    Console.WriteLine("\nWarning {0} is smaller than minimum", grade);
                }

                else
                {
                    restart = false;
                }

            } while (restart); 


            if (grade >= 90)
            {
                Console.WriteLine("Grade: A+");
            }

            else if (grade >= 80)
            {
                Console.WriteLine("Grade: A");
            }

            else if (grade >= 70)
            {
                Console.WriteLine("Grade: B+");
            }

            else if (grade >= 60)
            {
                Console.WriteLine("Grade: B");
            }

            else if (grade >= 50)
            {
                Console.WriteLine("Grade: C");
            }

            else if (grade >= 40)
            {
                Console.WriteLine("Grade: D");
            }

            else
            {
                Console.WriteLine("Grade: F");
            }
 

        }
        public static void task4()
        {
            int userNum = 0;
            Console.WriteLine("\nIs Your Number Odd Or Even?");
            Console.WriteLine("\nEnter Number");
            userNum = Int32.Parse(Console.ReadLine());

            userNum = userNum % 2;
            
            if (userNum == 0)
            {
                Console.WriteLine("The Number is Even");
            }

            else
            {
                Console.WriteLine("The number is Odd");
            }


        }
        public static void task5()
        {
            Boolean restart = true;

            int pin1;
            int pin2;
            Console.WriteLine("\nWelcome To The Vault");

            do {
                pin1 = 0;
                pin2 = 0;
                Console.WriteLine("\nEnter 4 Digit Code Here:");

                pin1 = Int32.Parse(Console.ReadLine());

                if (pin1 <= 1000 || pin1 >= 9999)
                {
                    Console.WriteLine("\nERROR: CODE NOT IN RIGHT PERAMETERS");
                    Console.WriteLine("SYSTEM LOCK");
                }

                else
                {
                    restart = false;
                }

            } while (restart);


              Console.WriteLine("\nPlease Enter PIN Again:");
              pin2 = Int32.Parse(Console.ReadLine());

              if (pin1 == pin2)
              {
                  Console.WriteLine("\nYour PIN Is Set");
              }

              else
              {
                  Console.WriteLine("\nERROR: PIN's NOT THE SAME");
                  Console.WriteLine("SYSTEM LOCK");
              }


        }
        public static void task6()
        {
            
            string char1, char2, char3;
            int i = 0;

            Console.WriteLine("\nWelcome to the Palindrome Scanner");
            Console.WriteLine("\nPlease think of a 3 letter word...");

            Console.WriteLine("Please Enter the first letter of the word");
            char1 = Console.ReadLine();

            Console.WriteLine("Please Enter the second letter of the word");
            char2 = Console.ReadLine();

            Console.WriteLine("Please Enter the third letter of the word");
            char3 = Console.ReadLine();

            if (char2 != "a, e, o, u")
            {
                Console.WriteLine("Not A Real Word");
            }

            else if (char1 == char3)
            {
                Console.WriteLine("That is a Palindrome");
            }

            else
            {
                Console.WriteLine("Not a Palindrome");
            }






        }



    }
}
