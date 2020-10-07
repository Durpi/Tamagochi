using System;
using System.Collections.Generic;

namespace Tamagochi
{
    public class Tamagochi
    {
        static Random generator = new Random();
        List<string> words = new List<string>() {"death", "beheading", "execution"};
        int hunger = 3;
        int boredom = 3;
        bool isAlive = true;
        public string name;

        public void Feed()
        {

            hunger -= 2;

        }


        public void Hi()
        {

            int whichWord = generator.Next(0, 3);
            string sayWord = words[whichWord];

            Console.WriteLine(sayWord);
            Console.ReadLine();
            ReduceBoredom();

        }

        public void Teach(string word)
        {

            words.Add(word);
            ReduceBoredom();

        }

        public void Tick()
        {

            hunger++;
            boredom++;
            if (hunger == 10 || boredom == 10)
            {
                isAlive = false;
            }

        }

        public void PrintStats()
        {

            Console.WriteLine(name + " har\n" + hunger + "/10 hunger" +
            "\n" + boredom + "/10 boredom");
           
            if (isAlive == true)
            {
                Console.WriteLine("The creature is alive");
            }
            else if (isAlive == false)
            {
                Console.WriteLine("The creature has died");
            }
            Console.ReadLine();
        }

        public bool GetAlive()
        {

            return isAlive;

        }

        private void ReduceBoredom()
        {

            boredom -= 2;

        }

    }
}
