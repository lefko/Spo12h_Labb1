using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12hLabb1
{
    class Animal
    {
        #region ------ Fields -------
        // Variabler

        private string name;
        private int age;

        #endregion

        #region ------- Constructors --------

        // Konstruktorer

        public Animal():this("Not named", 0)
        {
        }

        public Animal(string nm, int a)
        {
            Name = nm;
            Age = a;
        }

        #endregion

        #region --------- Properties ---------

        // Properties

        public string Name
        {
            get { return name; }
            set { name = value;}
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    age = 0;
            }
        }

        #endregion

        #region --------- Methods -----------

        // Metoder

        public override string ToString()
        {
            string s = "\nDjurets Detaljer: \nNamn: " + Name + "\nÅlder: " + Age;
            return s;
        }

        #endregion
    }
}
