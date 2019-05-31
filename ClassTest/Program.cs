using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var dog = new Animal("dog", "bow");
            dog.MakeSound();      
            var cow = new Animal("cow","soso");
            cow.MakeSound();
            var cat = new Animal("cat", "nu");
            cat.MakeSound();*/

            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("dog", "bow"));
            animals.Add(new Animal("cow", "soso"));
            animals.Add(new Animal("cat", "nu"));

            foreach(var animal in animals)
            {
                animal.MakeSound();
            }            

            Console.WriteLine("Animal num : {0}", Animal.GetNum0fAnimals());
            Console.WriteLine("=================================");
            Console.WriteLine("Area of Rect : {0}", ShapeMath.GetArea(enShape.Rectangle, 10, 20));
            Console.WriteLine("Area of Tri : {0}", ShapeMath.GetArea(enShape.Triangle, 10, 20));
            Console.WriteLine("Area of circle : {0}", ShapeMath.GetArea(enShape.Circle, 10, 20));
        }
    }
}
