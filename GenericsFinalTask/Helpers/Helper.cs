using GenericsFinalTask.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GenericsFinalTask.Helpers
{
    internal enum Operations
    {
        /// <summary>
        /// Menyunu gostermek
        /// </summary>
        GetAll = 1,
        /// <summary>
        /// Silmek
        /// </summary>
        Remove = 2,
        /// <summary>
        /// Elave etmek
        /// </summary>
        Add = 3,
        /// <summary>
        /// Deyisdirmek
        /// </summary>
        Update = 4,

    }

    internal enum UserTypes
    {
        /// <summary>
        /// Mushteri girishi ucun
        /// </summary>
        Mushteri = 1,
        /// <summary>
        /// Ishci girishi ucun
        /// </summary>
        Ishci = 2,
    }

    public static class Menu
    {

        #region GetAllMenu
        public static void GetAllMenu()
        {
            WriteLine("Menyu");
            WriteLine("Desertler:");
            DesertManager desertManager = new DesertManager();
            foreach (var desert in desertManager.GetAll())
            {
                WriteLine($"Id:{desert.Id},Name:{desert.Name},Price:{desert.Price}Azn,Indgrientler:{desert.Indrigient}");
            }
            WriteLine("--------------------------");

            WriteLine("Ickiler:");
            DrinkManager drinkManager = new DrinkManager();
            foreach (var drink in drinkManager.GetAll())
            {
                WriteLine($"Id:{drink.Id},Name:{drink.Name},Price:{drink.Price}Azn");
            }
            WriteLine("--------------------------");

            WriteLine("Fast-foodlar:");
            FastFoodManager fastFoodManager = new FastFoodManager();
            foreach (var fastFood in fastFoodManager.GetAll())
            {
                WriteLine($"Id:{fastFood.Id},Name:{fastFood.Name},Price:{fastFood.Price}Azn");
            }
            WriteLine("--------------------------");

            WriteLine("Yemekler:");
            MealManager mealManager = new MealManager();
            foreach (var meal in mealManager.GetAll())
            {
                WriteLine($"Id:{meal.Id},Name:{meal.Name},Price:{meal.Price}Azn,Indgrientler:{meal.Indrigient}");
            }
        }
            #endregion
        
    }
}
