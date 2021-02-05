using System;


namespace knowledgeConsole
{
    class Program
    {


        static void Choice()
        {
            string input = "";
            Console.WriteLine("Which will you choose? A or B?");
            input = Console.ReadLine();
            input = input.ToUpper();
            if (input != "A")
            {
                Console.WriteLine("You've chosen path B!");
            }
            else
            {
                Console.WriteLine("You've chosen path A!");
            }



        }

        static void Main(string[] args)
        {



            double powerLevel = 0.1;
            int lifePoints = 0;
            double dollars = 1.00;
            


            Console.WriteLine("Hello Learner, welcome to Knowledge. I am Eden. Here is your inventory:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("powerLevel: " + powerLevel);
            Console.WriteLine("lifePoints: " + lifePoints);
            Console.WriteLine("dollars: " + dollars);
            Console.WriteLine("----------------------------------------");

            Choice();
        }

   

         


       






    }
}




