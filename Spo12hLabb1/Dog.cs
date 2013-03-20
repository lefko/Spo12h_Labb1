using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12hLabb1
{
    public class Dog : Pet
    {
        #region ------ Fields -------

        // Variabler

        private string race;

        #endregion

        #region ------- Constructors --------

        // Konstruktorer

        public Dog() : base()
        {
            race = "ingen ras angiven";
        }

         public Dog(string name, int age, string owner, bool mood, string race) : base(name, age, owner, mood)
        {
            this.Race = race;
        }

        #endregion

        #region --------- Properties ---------

        // Properties

        public String Race
        {
            get { return race; }
            set { race = value; }
        }

        #endregion

        #region --------- Methods -----------

        // Metoder

        public override string ToString()
        {
            string dogMood;
            if (base.Mood == true)
                dogMood = "Viftar på svansen";
            else
                dogMood = "arg och otrevlig";

            string s = "\nDjurets Detaljer: \nNamn: " + Name + "\nÅlder: " + Age + "\nÄgare: " + Owner + "\nRas: " + Race + "\nHumör: " + dogMood;
            return s;
        }

        #endregion
    }
}
