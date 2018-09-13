using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_task2
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
            int[] num = new int[5];


            Console.WriteLine("\nReversing Input");
            Console.WriteLine("\nEnter 5 Numbers:");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Enter Number {0}:", i + 1);
                num[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("\nNormal");
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Number {0}:{1}", j, num[j]);

            }


            Console.WriteLine("\nReversed");
            for (int j = 5; j > 0; j--)
            {
                Console.WriteLine("Number {0}:{1}",j, num[j-1] );

            }


        }


        public static void Task2()
        {
            Console.WriteLine("\nTotal Program");
            Console.WriteLine("Please enter how many numbers you wish to store:");
            int userNum = int.Parse(Console.ReadLine());
            int[] storage = new int[userNum];

            Console.WriteLine("\nNumbers Displayed As Entered");
            for (int i = 0; i < storage.Length; i++)
            {
                
                Console.Write("Enter Number {0} (Array Index {1}:)", i + 1, i);
                storage[i] = int.Parse(Console.ReadLine());
                
            }

            int total = 0;
            Console.Write("\nArray Items Entered: ");
            for (int j = 0; j < storage.Length; j++)
            {
                Console.Write(" {0},", storage[j]);
                total = total + storage[j];

            }

            //foreach(int x in array1)
            //{
            //    Console.WriteLine(x);
            //    total += array1[1];
            //}


            Console.WriteLine("\nThe Total is: {0}",total );



        }


        public static void Task3()
        {
            Console.WriteLine("\nTwo Arrays");
            Console.WriteLine("Please Enter Numbers Into Array #1");
            int[] Array1 = new int[5];
            int[] Array2 = new int[5];

            for (int i = 0; i < Array1.Length; i++)
            {
                Console.Write("Enter Number {0} (Array Index {1}):", i + 1, i);
                Array1[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int j = 0; j < Array2.Length; j++)
            {

                Array2[j] = Array1[j];

            }


            Console.Write("\nArray2 Items:");
            for (int k = 0; k < Array2.Length; k++)
            {

                Console.Write(" {0}", Array2[k]);
                

            }


        }

        public static void Task4()
        {
            Console.WriteLine("\nMin Max");
            int[] Array1 = new int[5];
            Console.WriteLine("\nNumbers Displayed As Entered (5)");
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.Write("\nEnter Number {0} (Array Index {1}:)", i + 1, i);
                Array1[i] = Convert.ToInt32(Console.ReadLine());

            }


        
            int max = Array1[0];
            int min  = Array1[0];
            for (int j = 0; j < 5; j++)
            {
                
                if (max < Array1[j])
                {
                    max = Array1[j];
                }

                if (min  > Array1[j])
                {
                    min = Array1[j];
                }

            }

            Console.WriteLine("\nThe lowest number in the array:{0}", min);
            Console.WriteLine("The highest number in the array:{0}", max);
            



        }


    }
}
