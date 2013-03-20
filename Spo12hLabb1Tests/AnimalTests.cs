using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Spo12hLabb1;


namespace Spo12hLabb1Tests
{
    [TestFixture]
    public class AnimalTests
    {
        
        [Test]
        public void CreateAnimalWithDefConstructor()
        {
            Animal animal1 = new Animal();
            StringAssert.AreEqualIgnoringCase("Not Named", animal1.Name);
            Assert.AreEqual(0, animal1.Age);
        }

        [Test]
        public void CreateAnimalWithNameAndAge()
        {
            Animal animal2 = new Animal("Bronco", 3);
            StringAssert.AreEqualIgnoringCase("Bronco", animal2.Name);
            Assert.AreEqual(3, animal2.Age);
        }

        [Test]
        public void DenyAgeBellow0()
        {
            Animal myAnimal = new Animal();
            myAnimal.Age = -1;
            Assert.AreEqual(0, myAnimal.Age);
        }

        [Test]
        public void SetANewName()
        {
            Animal myAnimal = new Animal();
            myAnimal.Name = "Rocky";
            StringAssert.AreEqualIgnoringCase("Rocky", myAnimal.Name);
        }
    }
}
