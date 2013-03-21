using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12hLabb1
{

    public class Pet : Animal
    {
        #region ------ Fields -------
        // Variabler

        // Privata variabler. Sätts med Properties
        private string owner;
        private bool mood;

        #endregion

        #region ------- Constructors --------

        // Konstruktorer


        //Defaultkonstruktorn kallar på den från base-klassen och sätter sedan sina egna attribut
        public Pet():base()
        {
            owner = "No owner";
            mood = false;
        }

        // tar emot samtliga atribut (inkl de för baseklassen), klaara på base-klassens konstruktor.
        //Sätter sedan sina egna attribut
        public Pet(string name, int age, string owner, bool mood):base(name, age)
        {
            Owner = owner;
            Mood = mood;
        }

        #endregion

        #region --------- Properties ---------

        // Properties

        //Properties i denna klass kollar inget utan bara sätter/returnerar värdena
        public String Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public bool Mood
        {
            get { return mood; }
            set { mood = value; }
        }

        #endregion

        #region --------- Methods -----------

        // Metoder
        // Skriver inte ut Mood då det enast är användbart i subklasserna

        public override string ToString()
        {
            string s = base.ToString() + "\nÄgare: " + Owner;
            return s;
        }

        #endregion
    }
}
