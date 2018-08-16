using System;


namespace Tasks_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean restart = true;

            do
            {


                int choice = 0;

                Console.WriteLine("==================================");
                Console.WriteLine("===========TASKS 1 - 3============");
                Console.WriteLine("==================================");
                Console.WriteLine();
                Console.WriteLine("===================================");
                Console.WriteLine("Please select which task to access ");
                Console.WriteLine("=============1. 2. 3.==============");
                Console.WriteLine("Enter number here:");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Task1();

                }

                else if (choice == 2)
                {
                    Task2();
                   
                }
                else
                {
                    Task3();
                    

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
        public static void Task1()
        {
            //Task 1////////////////////////////////////////////////////////////////////////////////////////////////////

            //Initalising variables
            string name, gender, address;
            int age = 0;

            //Name input
            Console.WriteLine("Please type in Name:");
            name = Console.ReadLine();

            //Age input
            Console.WriteLine("\nPlease type in Age:");
            age = Convert.ToInt32(Console.ReadLine());

            //Gender input
            Console.WriteLine("\nPlease type in Gender:");
            gender = Console.ReadLine();

            //Address input
            Console.WriteLine("\nPlease type in Street Address:");
            address = Console.ReadLine();

            //Outputs
            Console.WriteLine("\nHello {0}.", name);
            Console.WriteLine("Your age is {0}.", age);
            Console.WriteLine("You are a {0}.", gender);
            Console.WriteLine("You live at {0}.", address);
            

            return;
            
        }

        public static void Task2()
        {
            //Task 2////////////////////////////////////////////////////////////////////////////////////////////////////

            //Initalising variables
            float num1 = 0, num2 = 0, ans = 0;
            string choice;

            //Inputs
            Console.WriteLine("Please type in first number:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please type in second number:");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please select which operator to use: +, -, *, /");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "+":
                    ans = num1 + num2;
                    break;

                case "-":
                    ans = num1 - num2;
                    break;

                case "*":
                    ans = num1 * num2;
                    break;

                case "/":
                    ans = num1 / num2;
                    break;
                default:
                    break;
            }

            Console.WriteLine("Calculating...");

            //Calculation output
            
            Console.WriteLine("\n{0} {1} {2} = {3}", num1, choice, num2, ans);


            return;
        }

        public static void Task3()
        {
            //Task 3////////////////////////////////////////////////////////////////////////////////////////////////////

            //initalising variables
            string Fname, Lname;


            //Names input
            Console.WriteLine("Please type in first name:");
            Fname = Console.ReadLine();
            Console.WriteLine("Please type in second name:");
            Lname = Console.ReadLine();

            //Output
            Console.WriteLine("\nHello {0} {1}.", Fname, Lname);
            //Another Method...
            Console.WriteLine("\nHello {0}" + " {1}", Fname, Lname);

            
            return;

        }


    }
}
