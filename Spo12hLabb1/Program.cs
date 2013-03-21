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

            Animal myAnimal = new Animal();
            Console.WriteLine("\nCreated new Animal using the def Constructor\n");
            Console.WriteLine(myAnimal.ToString());


            Animal myAnimal2 = new Animal("Rocky", 3);
            Console.WriteLine("\nCreated new Animal using the second Constructor\n");
            Console.WriteLine(myAnimal2.ToString());

            Animal myAnimal3 = new Animal();
            Console.WriteLine("\nDu håller på att skapa ett nytt djur");
            Console.Write("Ange djurets namn: ");
            myAnimal3.Name = Console.ReadLine();
            Console.Write("Ange djurets ålder: ");
            myAnimal3.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDu har angett:\n");
            Console.WriteLine(myAnimal3.ToString());

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
            //Häar ska det implementera HUMÖR ----------Jag vill inte ha med humör här egentligen--------------------!!!!!!!!!
            Console.WriteLine("\nDu har angett:\n");
            Console.WriteLine(myPet3.ToString());

            #endregion

            #region Cat Tester

            Cat myCat = new Cat();
            Console.WriteLine("\nCreated new Cat using the def Constructor\n");
            Console.WriteLine(myCat.ToString());


            Cat myCat2 = new Cat("Sylvia", 3, "Andreas", false, "svart");
            Console.WriteLine("\nCreated new Cat using the second Constructor\n");
            Console.WriteLine(myCat2.ToString());

            Cat myCat3 = new Cat();
            Console.WriteLine("\nDu håller på att skapa en ny Katt");
            Console.Write("Ange Kattens namn: ");
            myCat3.Name = Console.ReadLine();
            Console.Write("Ange Kattens ålder: ");
            myCat3.Age = int.Parse(Console.ReadLine());
            Console.Write("Ange Ägarens namn: ");
            myCat3.Owner = Console.ReadLine();
            Console.Write("Är katten på bra humör? skriv J för Ja eller N för Nej: ");
            string inMatningCat = "J";
            inMatningCat = Console.ReadLine();
            if (inMatningCat == "N" || inMatningCat == "n")
                myCat3.Mood = false;
            else
                myCat3.Mood = true;
            Console.WriteLine(myCat3.ToString());
   
            
            
            #endregion

            #region Dog Tests
            Dog myDog = new Dog();
            Console.WriteLine("\nCreated new Dog using the def Constructor\n");
            Console.WriteLine(myDog.ToString());


            Dog myDog2 = new Dog("Killer", 3, "Andreas", false, "Chefer");
            Console.WriteLine("\nCreated new Dog using the second Constructor\n");
            Console.WriteLine(myDog2.ToString());

            Dog myDog3 = new Dog();
            Console.WriteLine("\nDu håller på att skapa en ny Hund");
            Console.Write("Ange hundens namn: ");
            myDog3.Name = Console.ReadLine();
            Console.Write("Ange Hundens ålder: ");
            myDog3.Age = int.Parse(Console.ReadLine());
            Console.Write("Ange Ägarens namn: ");
            myDog3.Owner = Console.ReadLine();
            Console.Write("Är hunden på bra humör? skriv J för Ja eller N för Nej: ");
            string inMatningDog = "J";
            inMatningDog = Console.ReadLine();
            if (inMatningDog == "N" || inMatningDog == "n")
                myDog3.Mood = false;
            else
                myDog3.Mood = true;
            Console.WriteLine(myDog3.ToString());

            #endregion

            Console.ReadLine();
        }

        #region ------- Methods -------

        #endregion
    }
}
