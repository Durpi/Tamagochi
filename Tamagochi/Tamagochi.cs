using System;
using System.Collections.Generic;

namespace Tamagochi
{
    public class Tamagochi
    {
        Random generator = new Random();
        List<string> words = new List<string>() {"death", "beheading", "execution"};
        int hunger = 0;
        int boredom = 0;
        bool isAlive = true;
        public string name;

        public void Feed()
        {

            hunger--;

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

        }

        public void Tick()
        {

        }

        public void PrintStats()
        {

            Console.WriteLine("Tamagochin har " + hunger + "/10 hunger" +
            "\noch har " + boredom + "/10 boredom");

        }

        public bool GetAlive()
        {

            if (isAlive == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void ReduceBoredom()
        {

            boredom--;

        }

    }
}
