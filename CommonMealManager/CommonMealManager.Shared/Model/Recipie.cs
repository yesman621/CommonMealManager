using System;
using System.Collections.Generic;
using System.Text;

namespace CommonMealManager.Model
{
    class Recipie
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

        public Category Category
        {
            get;
            set;
        }

        public List<Ingredient> Ingredients
        {
            get;
            set;
        }

        // Constructors

        public Recipie(int id, string libelle, Category category)
        {
            Id = id;
            Libelle = libelle;
            Category = category;
        }

        public Recipie(int id, string libelle, Category category, List<Ingredient> ingredients) : this(id, libelle, category)
        {
            Ingredients = ingredients;
        }

        // Functions

        public void AddIngredient(Ingredient i)
        {
            Ingredients.Add(i);
        }

    }
}
