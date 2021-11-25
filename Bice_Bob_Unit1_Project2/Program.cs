using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ChatBot
{
    class Program
    {
        static void Main()
        {
            string Input1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("What do you want to say to the bot?");
                Input1 = Console.ReadLine();

                switch (Input1.ToLower())
                {
                    case "hello":
                        Console.WriteLine($"Hi good to see you");
                        break;

                    case "bye":
                        Console.WriteLine($"Good bye!");
                        break;

                    case "sup":
                        Console.WriteLine($"I am good");
                        break;

                    case "hello there":
                        Console.WriteLine($"General Kenobi");
                        break;

                }
                Console.WriteLine("Another Input?");
                if (Console.ReadLine() == Input1)
                {
                    Console.WriteLine("I’m sorry but you have already said that");

                }
                else

                    continue;


                if (Console.ReadLine() == "bye")
                {
                    return;
                }
            }

        }

    }

}