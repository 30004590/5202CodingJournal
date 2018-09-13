using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTasks
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
            Console.WriteLine("Enter Number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The number: {0}, is now changed to {1}",number, ChangeSign(number));

        }


        public static int ChangeSign(int number)
        {


            return number*-1;

        }

        public static void Task2()
        {
            Console.WriteLine("Please enter Miles:");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} Miles converts to {1} Km's", number, MilesConvert(number));


        }

        public static double MilesConvert(double number)
        {

           number = number / 0.62137;

            return number;
        }


        public static void Task3()
        {
            Console.WriteLine("Please enter Radius:");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("The Circumference of this circle: {0.0.00}", Circ(number));
            Console.WriteLine("The Area of this circle: {0.0.00}",Area(number));


        }


        public static double Circ(double number)
        {
            number =  3.1416 * 2 * number;

            return number;
        }

        public static double Area(double number)
        {
            number = 3.1416 * (number * number);

            return number;
        }


        public static void Task4()
        {


            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine("Enter Day Number:");
            int num = Int32.Parse(Console.ReadLine());
            DayCheck(num, days);
            


            

        }


        public static void DayCheck(int num, string [] days)
        {

            Console.WriteLine("The Day Is: {0}", days[num-1]);


            
        }




    }
}
