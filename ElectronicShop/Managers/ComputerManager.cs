using ElectronicShop.Classes;
using ElectronicShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop.Managers
{
    internal class ComputerManager : Computer, IComputer
    {
        public override string ProcessorType
        {
            get { return ProcessorType; }
            set
            {
                if (value == "Intel" || value == "Ryzen")
                {
                    ProcessorType = value;
                }
            }
        }
        public override int Ram
        {
            get { return Ram; }
            set
            {
                if (value < 4 || value > 128)
                {
                    throw new Exception("ram 4 ile 128 arasi olmalidir!");
                }
                Ram = value;
            }
        }
        public override double Price
        {
            get { return Price; }
            set
            {
                if (value < 1000 || value > 12000)
                {
                    throw new Exception("Bu qiymete komputer yoxdur!");
                }
                Price = value;
            }
        }
        public override string OperatingSystem
        {
            get { return OperatingSystem; }
            set
            {
                if (value == "Linux" || value == "Macos" || value == "Windows")
                {
                    OperatingSystem = value;
                }
            }
        }
        public void CalcPriceWithTax()
        {
            Console.WriteLine($"Yekun qiymeti: {Price - Price * 0.04}");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Model:{Model},Marka:{Marc},Emeliyyat sistemi:{OperatingSystem},Ram:{Ram},Prosessor:{ProcessorType}");
        }

        public void GetUsefullOrNot()
        {
            if (Ram > 4 && Ram < 8)
            {
                Console.WriteLine("Ofis isleri ucundur");
            }
            else if (Ram > 8 && Ram < 16)
            {
                Console.WriteLine("Proqramlasdirma ucundur");
            }
            else if (Ram > 16 && Ram < 32)
            {
                Console.WriteLine("Dizayn ucundur");
            }
            else if (Ram > 32 && Ram < 128)
            {
                Console.WriteLine("Oyun ucundur");
            }
            else
            {
                Console.WriteLine("Bilinmir");
            }
        }
    }
}
