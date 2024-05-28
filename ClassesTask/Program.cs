
using ClassesTask.Classes;




#region Product
Product product = new("Bread", "Food", 50, 5);
product.Info();
#endregion

#region Book
Book book1 = new Book();
book1.BookName = "Harry Potter";
book1.WriterName = "J. K. Rowling";
book1.Price = 100;
book1.GetInfo();
Book book2 = new Book();
book2.BookName = "Carles Puth";
book2.WriterName = "Thomas Muller";
book2.Price = 15;
book2.GetInfo();
#endregion



