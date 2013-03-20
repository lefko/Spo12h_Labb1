using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12hLabb1
{
    class Cat : Pet
    {
        #region ------ Fields -------

        // Variabler

        private string color;

        #endregion

        #region ------- Constructors --------

        // Konstruktorer
        public Cat():base()
        {
            color = "Ingen färg angedd";
        }

        public Cat(string name, int age, string owner, bool mood, string color) : base(name, age, owner, mood)
        {
            Color = color;
        }

        #endregion

        #region --------- Properties ---------

        // Properties

        //Cats enda propertie. Alla andra ärver den från base-klassen

        public String Color
        {
            get { return color; }
            set { color = value; }
        }

        #endregion

        #region --------- Methods -----------

        // Metoder
        public override string ToString()
        {
            string catMood;
            if (base.Mood == true)
                catMood = "spinner";
            else
                catMood = "arg och otrevlig";

            string s = "\nDjurets Detaljer: \nNamn: " + Name + "\nÅlder: " + Age + "\nÄgare: " + Owner + "\nFärg: " + Color + "\nHumör: " + catMood;
            return s;
        }

        #endregion
    }
}
