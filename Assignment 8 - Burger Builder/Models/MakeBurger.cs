using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerBuilder.Models
{
    class MakeBurger
    {
        public List<string> Ingredients { get; set; }

        public MakeBurger()
        {
            Ingredients = new List<string>();
            Ingredients.Add("buns");
            Ingredients.Add("lettuce");
        }

        public void AddCheese()
        {
            Ingredients.Add("cheese");
        }

        public void AddPickles()
        {
            Ingredients.Add("pickles");
        }

        public void AddMeat()
        {
            Ingredients.Add("meat");
        }

        public void AddChicken()
        {
            Ingredients.Add("chicken");
        }

        public void AddHotSause()
        {
            Ingredients.Add("hot sause");
        }

        public void AddSweetSause()
        {
            Ingredients.Add("sweet sause");
        }

        public void AddSpecialSause()
        {
            Ingredients.Add("special sause");
        }


        public void ShowAll()
        {
            Console.WriteLine("Your burger has following ingredients: ");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine(ingredient.ToString());
            }
        }


    }
}