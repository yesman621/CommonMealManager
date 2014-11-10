using System;
using System.Collections.Generic;
using System.Text;

namespace CommonMealManager.Model
{
    class Meal
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

        public DateTime DateMeal
        {
            get;
            set;
        }

        public List<Recipie> Recipies
        {
            get;
            set;
        }

        // Constructors

        public Meal(int id, string libelle, DateTime dateMeal)
        {
            Id = id;
            Libelle = libelle;
            DateMeal = dateMeal;
        }

        public Meal(int id, string libelle, DateTime dateMeal, List<Recipie> recipies) : this(id, libelle, dateMeal)
        {
            Recipies = recipies;
        }

        // Functions

        public void AddRecipie(Recipie r)
        {
            Recipies.Add(r);
        }
    }
}
