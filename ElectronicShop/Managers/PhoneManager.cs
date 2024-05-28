using ElectronicShop.Classes;
using ElectronicShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop.Managers
{
    internal class PhoneManager : Phone, IPhone
    {
        public Phone _phone;
        public PhoneManager(Phone phone)
        {
            _phone = phone;
        }
        public override double Price
        {
            get { return _phone.Price; }
            set
            {
                if (value < 100 || value > 6000)
                {
                    throw new Exception("Error");
                }
                _phone.Price = value;

            }
        }
        public override string OperatingSystem
        {
            get { return _phone.OperatingSystem; }
            set
            {
                if (value == "IOS" || value == "Android")
                {
                    _phone.OperatingSystem = value;
                }

            }
        }
        public override int CameraMegaPixels
        {
            get { return _phone.CameraMegaPixels; }
            set
            {
                if (value < 4 || value > 128)
                {
                    throw new Exception("4 ile 128 px arasinda olmalidir!");
                }
                _phone.CameraMegaPixels = value;
            }
        }
        public void CalcPriceWithTax()
        {
            Console.WriteLine($"Yekun qiymeti: {Price - Price * 0.04}");

        }

        public void CheckCamera()
        {
            if (4 <= CameraMegaPixels && 32 >= CameraMegaPixels)
            {
                Console.WriteLine("normal");
            }
            else if (32 < CameraMegaPixels && 64 >= CameraMegaPixels)
            {
                Console.WriteLine("yaxsi");
            }
            else if (CameraMegaPixels > 64)
            {
                Console.WriteLine("ela");
            }
            else
            {
                Console.WriteLine("pis");
            }

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Model:{Model},Marka:{Marc},Emeliyyat sistemi:{OperatingSystem},Kamera:{CameraMegaPixels}");
        }
    }
}
