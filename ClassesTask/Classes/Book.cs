using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask.Classes
{
    public class Book
    {
        public string Id { get; set; }

        private string bookName;
        public string BookName
        {
            get { return bookName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be empty");
                }
                bookName = value;
            }
        }
        private string writerName;

        public string WriterName
        {
            get { return writerName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The writer can not be empty");
                }
                writerName = value;
            }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("The Price must not be less than 0 or greater than 100");
                }
                price = value;
            }
        }
        private bool bestSeller;

        public bool BestSeller
        {
            get { return Price > 20; ; }
        }
        public Book()
        {
            Id = Guid.NewGuid().ToString();
        }
        public void GetInfo()
        {
            Console.WriteLine($"Id: {Id} \n " +
                 $"Book Name: {bookName} \n " +
                 $"Writer Name: {writerName} \n " +
                 $"Price: {price} \n " +
                 $"Best Seller: {BestSeller}");
        }
    }
}
