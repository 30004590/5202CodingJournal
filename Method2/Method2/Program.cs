using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
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
                        Task1();
                        break;


                    case 2:
                        Task2();
                        break;

                    case 3:
                        Task3();
                        break;

                    case 4:
                        Task4();
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

        public static void Task1()
        {
            Console.WriteLine("Enter Weight(Kg):");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height(cm):");
            float height = float.Parse(Console.ReadLine())/100;

            float BMI = BmiCalc(weight, height);
            string category = BmiCategory(BMI);


            Console.WriteLine("\nYour BMI is: {0}", BMI);
            Console.WriteLine("Your BMI Catergory is: {0}", category);
        }

        public static float BmiCalc(float weight, float height)
        {
            float BMI = weight / (height * height);
            return BMI;

        }

        public static string BmiCategory(float BMI)
        {
            string category = "";

            if (BMI <= 30)
            {
                category = "Obese";
            }
            else if (BMI <=25 || BMI >30 )
            {
                category = "Overweight";
            }
            else if (BMI <= 18.5 || BMI > 25)
            {
                category = "Normal weight";
            }
            else
            {
                category = "Underweight";
            }


            return category;

        }

        public static void Task2()
        {
            Console.WriteLine("Enter starting digit of Cents: e.g. 1");
            int cents = int.Parse(Console.ReadLine());

          

            string round = TransactionRound(cents);
            Console.WriteLine("\nThe rounding should be: {0}", round);


        }


        public static string TransactionRound (int cents)
        {
            string round = "";

            switch (cents)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    round = "Round Down";
                    break;  

                case 6:
                case 7:
                case 8:
                case 9:
                    round = "Round Up";
                    break;
                    
            }

            return round;
        }


        public static void Task3()
        {

            Console.WriteLine("");
            Console.WriteLine("1. English");
            Console.WriteLine("2. Maori");
            Console.WriteLine("3. Japanese");
            Console.WriteLine("4. Hindi");
            Console.WriteLine("5. French");
            
            Console.WriteLine("\nEnter choice (number) for Hello in a different translation:");
            int choice = int.Parse(Console.ReadLine());

            string greeting = Translate(choice);
            Console.WriteLine("Your choice was {0}, {1}",choice,greeting);


        }


        public static string Translate(int choice)
        {
            string[] lang = { "Hello","Kia ora","Kon'nichiwa","Bonjour","Talofa" };
            string greeting = lang[choice-1];


            return greeting;

        }


        public static void Task4()
        {
            Console.WriteLine("\nCalculator");

            Console.WriteLine("Enter 1st number");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operator E.g. +,-,*,/");
            string op = Console.ReadLine();

            Console.WriteLine("Enter 2nd number");
            float num2 = float.Parse(Console.ReadLine());

            float answer = Calc(num1, num2, op);

            Console.WriteLine("\n{0} {1} {2} = {3}",num1, op, num2, answer);

        }

        private static float Calc(float num1, float num2, string op)
        {

            float answer = 0;


            switch (op)
            {
                case "+":
                    answer = num1 + num2;
                    break;


                case "-":
                    answer = num1 - num2;
                    break;

                case "*":
                    answer = num1 * num2;
                    break;

                case "/":
                    answer = num1 / num2;
                    break;
            }
            return answer;

        }


    }
}
