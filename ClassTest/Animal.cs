using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTest
{
    class Animal
    {
        static int num0fAnimals =0;

        private string name;
        private string sound;

        public Animal()
        {
            num0fAnimals++;
        }

        public Animal(string n, string s)
        {
            name = n;
            sound = s;
            num0fAnimals++;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1} num: {2}", name, sound, GetNum0fAnimals());
        }

        public static int GetNum0fAnimals()
        {
            return num0fAnimals;
        }
    }
}
