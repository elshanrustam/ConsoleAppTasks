using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop.Classes
{
    public class Phone
    {
        public string PhoneName { get; set; }
        public string PhoneModel { get; set; }
        public string CompanyName { get; set; }
        public int Price { get; set; }
    }
    public class Iphone : Phone
    {

    }
    public class Samsung : Phone
    {

    }
    public class Xiaomi : Phone
    {

    }
}
