using System;
using System.Collections.Generic;
using System.Text;

namespace CommonMealManager.Model
{
    class Category
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

        // Constructors

        public Category(int id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }

    }
}
