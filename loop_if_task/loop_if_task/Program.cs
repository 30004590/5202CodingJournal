using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_if_task
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
            Console.WriteLine("Odd numbers from 76 to 46 (descending)");

            int i = 76, num = 0, end = 46;
           
            while ( i > end)
            {
                

                num = i % 2;
                i--;
                if (num == 0){
                    Console.WriteLine("{0}",i);
                }


            }

        }


        public static void task2()
        {
            Console.WriteLine("Repeat Inputs");
            
            Console.WriteLine("\nPlease Enter Symbol:");
            char userSym = char.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease Enter Increment Value:");
            int userNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nFor Loop");
            Console.WriteLine();
            int i = 1;
            for (i = 1; i <=userNum  ; i ++)
            {
                Console.Write("{0}",userSym);
            }


            Console.WriteLine("\nWhile Loop");
            Console.WriteLine();
            i = 1;
            while (i  <= userNum )
            {
                Console.Write("{0}", userSym);
                i++;
            }

            Console.WriteLine("\nDo While Loop");
            i = 1;
            do
            {
                Console.Write("{0}", userSym);
                i++;
            } while (i <= userNum);



        }


        public static void task3()
        {
            Console.WriteLine("\nRectangle");
            Console.WriteLine("\nEnter Width");
            int width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height");
            int height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Symbol");
            char userSym = char.Parse(Console.ReadLine());


            Console.WriteLine("The Rectangle Will Be {0} Wide and {1} High and will Use {2}", width, height, userSym);

            Console.WriteLine("\nWhile Loop");
            int i = 0;
            int j = 0;
            while (i < height)
            {

           
                for (j = 0; j < width; j++)
                {
                    Console.Write("{0}", userSym);
                }


                Console.WriteLine();
                i++;
            }

            Console.WriteLine("\nFor Loop");
            i = 0;
            j = 0;
            for (i = 0; i < height; i++)
            {
                for (j = 0; j < width; j++)
                {
                    Console.Write("{0}", userSym);
                }

               Console.WriteLine();
                
            }

            Console.WriteLine("\nDo While Loop");




        }




    }

}
