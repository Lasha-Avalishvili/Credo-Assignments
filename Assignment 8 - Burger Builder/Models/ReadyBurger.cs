using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerBuilder.Models
{
    class ReadyBurger
    {
        public List<string> Ingredients { get; set; }

        public ReadyBurger()
        {
            Ingredients = new List<string>();

            Ingredients.Add("lettuce");
            Ingredients.Add("buns");
        }

        public void MakeCheeseburger()
        {
            Ingredients.Add("cheese");
            Ingredients.Add("pickles");
            Ingredients.Add("hot sause");
        }

        public void MakeHamburger()
        {
            Ingredients.Add("ham");
            Ingredients.Add("pickles");
            Ingredients.Add("sweet sause");
        }
        public void MakeSpecialburger()
        {
            Ingredients.Add("chicken");
            Ingredients.Add("pickles");
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
