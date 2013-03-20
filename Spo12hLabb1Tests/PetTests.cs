using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Spo12hLabb1;

namespace Spo12hLabb1Tests
{
    [TestFixture]
    class PetTests
    {
        [Test]
        public void CreatePetWithDefConstructor()
        {
            Pet pet1 = new Pet();
            StringAssert.AreEqualIgnoringCase("Not Named", pet1.Name);
            Assert.AreEqual(0, pet1.Age);
        }

        [Test]
        public void CreatePetWithNameAndAge()
        {
            Pet pet2 = new Pet("Bronco", 3, "Andreas", true);
            StringAssert.AreEqualIgnoringCase("Bronco", pet2.Name);
            Assert.AreEqual(3, pet2.Age);
            StringAssert.AreEqualIgnoringCase("Andreas", pet2.Owner);
            Assert.True(pet2.Mood);
        }

        [Test]
        public void DenyAgeBellow0()
        {
            Pet myPet = new Pet();
            myPet.Age =-1;
            Assert.AreEqual(0, myPet.Age);
        }

        [Test]
        public void SetANewName()
        {
            Pet myPet = new Pet();
            myPet.Name = "Rocky";
            StringAssert.AreEqualIgnoringCase("Rocky", myPet.Name);
        }
    }
}
