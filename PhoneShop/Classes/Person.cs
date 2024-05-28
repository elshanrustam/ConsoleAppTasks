using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop.Classes
{
    internal class Person
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Surname { get; set; }


        private int balance;

        public int Balance
        {
            get { return balance; }
            set
            {
                if (value > 8000 || value < 100)
                {
                    throw new Exception("Error");
                }
                else
                {
                    balance = value;
                }
            }
        }



    }
}
