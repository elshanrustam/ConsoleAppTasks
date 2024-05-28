using GenericsFinalTask.Classes;
using GenericsFinalTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFinalTask.Managers
{
    internal class FastFoodManager : GenericManager<FastFood>, IFastFood
    {
        public FastFoodManager() : base(new List<FastFood>
        {
            new FastFood{Id=1,Name="Doner",Price=3},
            new FastFood{Id=2,Name="Kartof fri",Price=5}
        })
        {

        }
    }
}
