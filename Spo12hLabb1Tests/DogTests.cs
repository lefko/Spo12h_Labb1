using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Spo12hLabb1;


namespace Spo12hLabb1Tests
{
    [TestFixture]
    class DogTests
    {
        [Test]
        public void CreateDogWithDefConstructor()
        {
            Dog dog1 = new Dog();
            StringAssert.AreEqualIgnoringCase("Ingen ras angiven", dog1.Race);
        }

        [Test]
        public void CreateDogWithSecondConstructor()
        {
            Dog dog2 = new Dog("Sam", 3, "Andreas", true, "wolf");
            StringAssert.AreEqualIgnoringCase("Sam", dog2.Name);
            Assert.AreEqual(3, dog2.Age);
            StringAssert.AreEqualIgnoringCase("Andreas", dog2.Owner);
            Assert.True(dog2.Mood);
            StringAssert.AreEqualIgnoringCase("wolf", dog2.Race);
        }

        [Test]
        public void ChangeDogRace()
        {
            Dog dog3 = new Dog();
            dog3.Race = "Labrador";
            StringAssert.AreEqualIgnoringCase("Labrador", dog3.Race);
        }

    }
}
