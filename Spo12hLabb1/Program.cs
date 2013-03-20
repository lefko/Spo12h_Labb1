using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12hLabb1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Animal Tester

            //Animal myAnimal = new Animal();
            //Console.WriteLine("\nCreated new Animal using the def Constructor\n");
            //Console.WriteLine(myAnimal.ToString());
            

            //Animal myAnimal2 = new Animal("Rocky", 3);
            //Console.WriteLine("\nCreated new Animal using the second Constructor\n");
            //Console.WriteLine(myAnimal2.ToString());

            //Animal myAnimal3 = new Animal();
            //Console.WriteLine("\nDu håller på att skapa ett nytt djur");
            //Console.Write("Ange djurets namn: ");
            //myAnimal3.Name = Console.ReadLine();
            //Console.Write("Ange djurets ålder: ");
            //myAnimal3.Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nDu har angett:\n");
            //Console.WriteLine(myAnimal3.ToString());

            #endregion

            #region Pet Tester

            Pet myPet = new Pet();
            Console.WriteLine("\nCreated new Pet using the def Constructor\n");
            Console.WriteLine(myPet.ToString());


            Pet myPet2 = new Pet("Rocky", 3, "Andreas", false);
            Console.WriteLine("\nCreated new Pet using the second Constructor\n");
            Console.WriteLine(myPet2.ToString());

            Pet myPet3 = new Pet();
            Console.WriteLine("\nDu håller på att skapa ett nytt Husdjur");
            Console.Write("Ange djurets namn: ");
            myPet3.Name = Console.ReadLine();
            Console.Write("Ange djurets ålder: ");
            myPet3.Age = int.Parse(Console.ReadLine());
            Console.Write("Ange Ägarens namn: ");
            myPet3.Owner = Console.ReadLine();
            // Häar ska det implementera HUMÖR ------------------------------!!!!!!!!!
            Console.WriteLine("\nDu har angett:\n");
            Console.WriteLine(myPet3.ToString());

            #endregion
            Console.ReadLine();
        }
    }
}
