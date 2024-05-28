using GenericsFinalTask.Classes;
using GenericsFinalTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFinalTask.Managers
{
    internal class DrinkManager : GenericManager<Drink>, IDrink
    {
        public DrinkManager() : base(new List<Drink>
        {
            new Drink{Id=1,Name="Kola",Price=2},
            new Drink{Id=2,Name="Fanta",Price=2},
        })
        {

        }
    }
}
