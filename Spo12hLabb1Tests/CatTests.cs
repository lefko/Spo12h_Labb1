using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Spo12hLabb1;

namespace Spo12hLabb1Tests
{
    [TestFixture]
    class CatTests
    {
        [Test]
        public void CreateCatWithDefConstructor()
        {
            Cat cat1 = new Cat();
            StringAssert.AreEqualIgnoringCase("Ingen färg angedd", cat1.Color);
        }

        [Test]
        public void CreateCatWithSecondConstructor()
        {
            Cat cat2 = new Cat("Sam", 3, "Andreas", true, "black");
            StringAssert.AreEqualIgnoringCase("Sam", cat2.Name);
            Assert.AreEqual(3, cat2.Age);
            StringAssert.AreEqualIgnoringCase("Andreas", cat2.Owner);
            Assert.True(cat2.Mood);
            StringAssert.AreEqualIgnoringCase("black", cat2.Color);
        }

      [Test]
      public void ChangeCatColor()
      {
          Cat cat3 = new Cat();
          cat3.Color = "Yellow";
          StringAssert.AreEqualIgnoringCase("Yellow", cat3.Color);
      }
       

    }
}
