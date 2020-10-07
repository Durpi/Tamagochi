using System.Threading;
using System.IO;
using System;

namespace Tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagochi tamagochi = new Tamagochi();

            Console.WriteLine("What will you name the creature?");
            tamagochi.name = Console.ReadLine();
            Console.WriteLine("What a lovely name for the creature, " + tamagochi.name);

            Sleep();

            while (tamagochi.GetAlive() == true)
            {
                
                tamagochi.PrintStats();

                Sleep();

                Console.WriteLine("Please chose what you want to do with " + tamagochi.name + 
                "\n[teach]" + 
                "\n[greet]" + 
                "\n[feed]" + 
                "\n[nothing]");

                string answer = Console.ReadLine();

                if (answer.ToLower() == "teach")
                {
                    
                }

            }

            Console.ReadLine();
        }


        private static void Sleep()
        {
            Thread.Sleep(3000);
        }
    }
}
