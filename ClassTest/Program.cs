using System;

namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal("dog", "bow");
            dog.MakeSound();
            Animal cow = new Animal("cow","soso");
            cow.MakeSound();
            Animal cat = new Animal("cat", "nu");
            cat.MakeSound();
            

        }
    }
}
