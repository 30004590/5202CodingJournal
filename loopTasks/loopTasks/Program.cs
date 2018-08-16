using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopTasks
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

            int i = 3;
            Console.WriteLine("\nN.    10*    100*    1000*");
            


            Console.WriteLine("\n>>>>>>>>>>For Loop<<<<<<<<<<<<<");
            for (i = 3; i <=7; i++)
            {
                Console.WriteLine($"{i}     {i*10}     {i*100}     {i*1000}");
            }


            Console.WriteLine("\n>>>>>>>>>>While Loop<<<<<<<<<<<<");
            i = 3;
            while (i <= 7)
            {
                Console.WriteLine($"{i}     {i * 10}     {i * 100}     {i * 1000}");
                i++;
            }

            Console.WriteLine("\n>>>>>>>>>Do While Loop<<<<<<<<<<<");
            i = 3;
            do
            {
                Console.WriteLine($"{i}     {i * 10}     {i * 100}     {i * 1000}");
                i++;
            } while (i <=7);


        }

        public static void task2()
        {

            int userNum = 0;
            Console.WriteLine("\nInput Times Table");
            Console.WriteLine("Please Enter Number:");
            userNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} times table", userNum);
            Console.WriteLine("\n>>>>>>>>>>For Loop<<<<<<<<<<<<<");
            int i = 0;
            for (i = 0; i <=12; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", userNum, i, userNum*i);
            }

            Console.WriteLine("\n>>>>>>>>>>While Loop<<<<<<<<<<<<");
            i = 0;
            while (i <= 12)
            {
                Console.WriteLine("{0} * {1} = {2}", userNum, i, userNum * i);
                i++;
            }

            Console.WriteLine("\n>>>>>>>>>Do While Loop<<<<<<<<<<<");
            i = 0;
            do
            {
                Console.WriteLine("{0} * {1} = {2}", userNum, i, userNum * i);
                i++;
            } while (i <= 12);

        }


        public static void task3()
        {
            int i = 0;
            Console.WriteLine("Num:     Square:     Cube:");
            Console.WriteLine("\n>>>>>>>>>>For Loop<<<<<<<<<<<<<");
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}           {1}         {2}", i, i*i, i*i*i);
            }


            Console.WriteLine("\n>>>>>>>>>>While Loop<<<<<<<<<<<<");
            i = 0;
            while (i <= 10)
            {
                Console.WriteLine("{0}           {1}         {2}", i, i * i, i * i * i);
                i++;
            }

            Console.WriteLine("\n>>>>>>>>>Do While Loop<<<<<<<<<<<");
            i = 0;
            do
            {
                Console.WriteLine("{0}           {1}         {2}", i, i * i, i * i * i);
                i++;
            } while (i <= 10);

        }






    }
}
