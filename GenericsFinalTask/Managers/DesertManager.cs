using GenericsFinalTask.Classes;
using GenericsFinalTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFinalTask.Managers
{
    internal class DesertManager : GenericManager<Desert>, IDesert
    {
        public DesertManager() : base(new List<Desert>
        {
            new Desert{Id=1,Name="Tort",Price=30,Indrigient="Un,Yumurta,Sud"},
            new Desert{Id=2,Name="Pecenye",Price=30,Indrigient="Un,Seker,Sud"},
        })
        {

        }
    }
}
