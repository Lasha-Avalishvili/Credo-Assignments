using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using BurgerBuilder.Models;

namespace BurgerBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Would you like to 1.Build your own burger or 2.Choose from the list ?");
                string chooseIndex = Console.ReadLine();
                string chooseBurger;

                if (chooseIndex == "1")
                {
                    MakeBurger burger = new MakeBurger();

                    while (true)
                    {
                        Console.WriteLine("Would you like cheese? (y/n)");
                        var answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            burger.AddCheese();
                            break;
                        }
                        else if (answer == "n")
                        {
                            break;
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine("Would you like pickles? (y/n)");
                        var answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            burger.AddPickles();
                            break;
                        }
                        else if (answer == "n")
                        {
                            break;
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine("Choose meat type: 1.chicken 2.beef 3.none  (1/2/3)");
                        var answer = Console.ReadLine();
                        if (answer == "1")
                        {
                            burger.AddChicken();
                            break;
                        }
                        else if (answer == "2")
                        {
                            burger.AddMeat();
                            break;
                        }
                        else if (answer == "3")
                        {
                            break;
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine("Choose sause: 1.Hot 2.Sweet 3.Special 4.None (1/2/3/4)");
                        var answer = Console.ReadLine();
                        if (answer == "1")
                        {
                            burger.AddHotSause();
                            break;
                        }
                        else if (answer == "2")
                        {
                            burger.AddSweetSause();
                            break;
                        }
                        else if (answer == "3")
                        {
                            burger.AddSpecialSause();
                            break;
                        }
                        else if (answer == "4")
                        {
                            break;
                        }
                    }
                    burger.ShowAll();
                    break;

                }

                else if (chooseIndex == "2")
                {
                    while (true)
                    {

                        Console.WriteLine("Which one do you want? 1.CheeseBurger 2.Hamburger 3.Special Burger");
                        chooseBurger = Console.ReadLine();

                        if (chooseBurger == "1")
                        {
                            ReadyBurger myburger = new ReadyBurger();
                            myburger.MakeCheeseburger();

                            myburger.ShowAll();
                            break;
                        }

                        else if (chooseBurger == "2")
                        {
                            ReadyBurger myburger = new ReadyBurger();
                            myburger.MakeHamburger();

                            myburger.ShowAll();
                            break;
                        }
                        else if (chooseBurger == "3")
                        {
                            ReadyBurger myburger = new ReadyBurger();
                            myburger.MakeSpecialburger();
                            myburger.ShowAll();
                            break;
                        }

                    }

                    break;

                }

            }

        }
    }
}