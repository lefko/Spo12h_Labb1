using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12hLabb1
{
    public class Animal
    {
        #region ------ Fields -------
        // Variabler

        // privata variabler. Sätts med Properties
        private string name;
        private int age;

        #endregion

        #region ------- Constructors --------

        // Konstruktorer

        // Default-konstruktor. Kallar på den andra konstruktor som sätter värdena till default
        public Animal():this("Not named", 0)
        {
        }

        //Andra konstruktorn som tar emot parametrar för samtliga fält
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        #endregion

        #region --------- Properties ---------

        // Properties

        public string Name
        {
            get { return name; }
            set { name = value;}
        }

        // Denna prppertie har kolla så att age alldrig kan bli under 0
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

        // ToString metod som innehåller info om samtliga attribut
        public override string ToString()
        {
            string s = "\nDjurets Detaljer: \nNamn: " + Name + "\nÅlder: " + Age;
            return s;
        }

        #endregion
    }
}
