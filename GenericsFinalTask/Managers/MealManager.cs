using GenericsFinalTask.Classes;
using GenericsFinalTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFinalTask.Managers
{
    internal class MealManager : GenericManager<Meal>, IMeal
    {
        public MealManager() : base(new List<Meal>
        {
            new Meal{Id=1,Name="Kabab",Price=4,Indrigient="Duz,Istiot"},
            new Meal{Id=2,Name="As",Price=5,Indrigient="Duyu,Duz"}
        })
        {

        }
    }
}
