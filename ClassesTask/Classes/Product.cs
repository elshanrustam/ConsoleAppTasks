using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask.Classes
{
    internal class Product
    {
        public string ProductId { get; private set; } = Guid.NewGuid().ToString();
        public string ProductName { get; set; }
        public int Price { get; private set; }
        private string _categoryName { get; set; }
        public int CountOfStock { get; private set; }
        public bool InStock
        {
            get
            {
                return CountOfStock > 0;
            }
        }


        public Product(string productName, string categoryName, int price, int countOfStock)
        {
            ProductName = productName;
            _categoryName = categoryName;
            Price = price;
            CountOfStock = countOfStock;
        }
        public void Info()
        {
            Console.WriteLine($"Product Id: {ProductId} \n " +
                $"Product Name: {ProductName} \n " +
                $"Product Price: {Price} \n" +
                $"Product Stock: {InStock}");
        }
    }
}
