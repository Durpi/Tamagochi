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
            bool play = true;

            while (play == true)
            {

                Console.WriteLine("What will you name the creature?");
                tamagochi.name = Console.ReadLine();
                Console.WriteLine("What a lovely name for the creature, " + tamagochi.name);


                Sleep();

                while (tamagochi.GetAlive() == true)
                {

                    tamagochi.PrintStats();

                    Sleep();

                    Console.WriteLine("Please choose what you want to do with " + tamagochi.name +
                    "\n[teach]" +
                    "\n[greet]" +
                    "\n[feed]" +
                    "\n[nothing]");

                    string answer = Console.ReadLine().ToLower();

                    while (answer != "teach" && answer != "greet" && answer != "feed" && answer != "nothing")
                    {

                        Console.WriteLine("Please choose between the four things to do");
                        answer = Console.ReadLine().ToLower();

                    }

                    if (answer == "teach")
                    {
                        Console.WriteLine("PLease write a word you want to teach " + tamagochi.name);
                        string learnWord = Console.ReadLine();

                        tamagochi.Teach(learnWord);

                    }
                    else if (answer == "greet")
                    {

                        Console.WriteLine("You greet " + tamagochi.name);

                        tamagochi.Hi();

                    }
                    else if (answer == "feed")
                    {

                        Console.WriteLine("You feed " + tamagochi.name);

                        tamagochi.Feed();

                    }
                    else if (answer == "nothing")
                    {

                        Console.WriteLine("You did nothing...");

                    }


                    tamagochi.Tick();
                    Sleep();
                    Console.Clear();

                }

                Console.WriteLine("YOU KILLED " + tamagochi.name + "! YOU BASTARD!");
                Sleep();

                Console.WriteLine("Do you want to try again and not kill your tamagochi?" + 
                "\n[yes]" +
                "\n[no]");
                string continuePlay = Console.ReadLine().ToLower();
                if (continuePlay == "yes")
                {
                    Console.WriteLine("Try not to kill your pet this time");
                    Sleep();
                    Console.Clear();
                }
                else if (continuePlay == "no")
                {
                    play = false;
                }

            }

            Console.ReadLine();
        }


        private static void Sleep()
        {
            Thread.Sleep(2000);
        }
    }
}
