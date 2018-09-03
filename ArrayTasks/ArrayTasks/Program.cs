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
            Console.WriteLine("\nCrankWorx Medal Awards");

            String [] names = new String[3];

            Console.WriteLine("\nPlease Enter GOLD Winner Name:");
            names[0] = Console.ReadLine();

            Console.WriteLine("\nPlease Enter SLIVER Winner Name:");
            names[1] = Console.ReadLine();

            Console.WriteLine("\nPlease Enter BRONZE Winner Name:");
            names[2] = Console.ReadLine();

            Console.WriteLine("\nWhich Medal Holder Name Do You Wish To View?");
            Console.WriteLine("1. 2. 3.");

            int userInput = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(names[userInput]);

            if (userInput == 1)
            {
                Console.WriteLine("\nGold Medal went to: {0}", names [0]);
            }

            else if (userInput == 2)
            {
                Console.WriteLine("\nSilver Medal went to: {0}", names[1]);
            }

            else if (userInput == 3)
            {
                Console.WriteLine("\nBronze Medal went to: {0}", names[2]);
            }





        }

        public static void Task2()
        {
           
            String[] names = new String[5];

            Console.WriteLine("Enter 5 Names:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("\nEnter name {0}:",i + 1);
                names[i] = Console.ReadLine();
            }

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("{0}. {1}",j + 1,names [j]);
            }

            Console.WriteLine("First Name Entered: {0}", names [0]);
            Console.WriteLine("Last Name Entered: {0}", names[4]);

        }

        public static void Task3()
        {
            String[] names = new String[20];

            Console.WriteLine("Enter 20 Names:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter name {0}:", i + 1);
                names[i] = Console.ReadLine();
            }

            Random rnd = new Random();
            Console.WriteLine("The Winner of the Lottery is: {0}", names [rnd.Next(0, 19)]);


        }

        public static void Task4()
        {
            String[] translation = new String[5];
            translation[0] = "Hello";
            translation[1] = "Kia ora";
            translation[2] = "Kon'nichiwa";
            translation[3] = "Namaste";
            translation[4] = "Bonjour";

            Console.WriteLine("\nThis Porgram can say hello in:");
            Console.WriteLine("1.English");
            Console.WriteLine("2.Maori");
            Console.WriteLine("3.Japanese");
            Console.WriteLine("4.Hindi");
            Console.WriteLine("5.French");

            Console.WriteLine("\nPlease select which Translation you want for Hello?");
            Console.WriteLine("1. 2. 3. 4. 5.");
            int userInput = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("\nYour Chosen Translation is: {0}", userInput);
            Console.WriteLine("\n"+translation[userInput]);



        }



    }
}
