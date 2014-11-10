using System;
using System.Collections.Generic;
using System.Text;

namespace CommonMealManager.Model
{
    class Ingredient
    {
        // Properties

        public int Id
        {
            get;
            set;
        }

        public string Libelle
        {
            get;
            set;
        }

        public double Quantity
        {
            get;
            set;
        }

        // Constructors

        public Ingredient(int id, string libelle, double quantity)
        {
            Id = id;
            Libelle = libelle;
            Quantity = quantity;
        }

    }
}
