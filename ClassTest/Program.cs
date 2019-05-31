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

            Console.WriteLine("Animal num : {0}", Animal.GetNum0fAnimals());
            Console.WriteLine("=================================");
            Console.WriteLine("Area of Rect : {0}", ShapeMath.GetArea(enShape.Rectangle, 10, 20));
            Console.WriteLine("Area of Tri : {0}", ShapeMath.GetArea(enShape.Triangle, 10, 20));
            Console.WriteLine("Area of circle : {0}", ShapeMath.GetArea(enShape.Circle, 10, 20));
        }
    }
}
