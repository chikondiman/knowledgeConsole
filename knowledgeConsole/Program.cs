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
                Console.WriteLine("You've chosen path A the path of a champion!");
            }



        }

        static void Simulation()
        {
            int simPoints = 0;
            string input = "";
            Console.WriteLine("Hola, buenas noches! Gracias para venir");
            Console.WriteLine("Que te gusta hacer para dinero?");
            Console.WriteLine("(A)Bailar, (B)Correr");
            input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                simPoints = simPoints + 1;
             
                Console.WriteLine("Si, me gustan muchos tus videos por youtube! [+]" + simPoints);
            
                
            }
            else
            {
                simPoints = simPoints - 1;
                Console.WriteLine("Mentiroso, ya sabemos que eres un bailarín" + simPoints);
            }


            Console.WriteLine("Que te gusta hacer para dinero?");
            Console.WriteLine("(A)Bailar, (B)Correr");
            input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                simPoints = simPoints + 1;

                Console.WriteLine("Si, me gustan muchos tus videos por youtube! [+]" + simPoints);


            }
            else
            {
                simPoints = simPoints - 1;
                Console.WriteLine("Mentiroso, ya sabemos que eres un bailarín" + simPoints);
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

            Simulation();
        }

   

         


       






    }
}




