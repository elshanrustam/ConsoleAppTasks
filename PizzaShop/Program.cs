using PizzaShop.Classes;
using static PizzaShop.Classes.Pizza;


Person person = new Person();
person.Balance = 85;

Pizza pizza = new Pizza();
Console.WriteLine("Seciminiz hansidir?");
Console.WriteLine("Margaritta");
Console.WriteLine("Peperonni");

pizza.PizzaType = Console.ReadLine();

if (pizza.PizzaType == "Margaritta")
{
    Console.WriteLine("Kart melumatlarinizi daxil edin:");
    Console.WriteLine("Kart hesabinizi daxil edin:");
    person.CardNumber = Console.ReadLine();
    Console.WriteLine("Kart bitme muddetini  daxil edin:");
    person.ExpDate = Console.ReadLine();
    Console.WriteLine("Kart CVV ni daxil edin:");
    person.CVV = Console.ReadLine();

    if (person.CardNumber.Length == 16 && person.ExpDate.Length == 5 && person.CVV.Length == 3)
    {
        Margaritta margaritta = new Margaritta();
        Console.WriteLine("Pizzanin olcusun daxil edin:");
        margaritta.PizzaSize = Console.ReadLine();
        Console.WriteLine("Pizzaniz hazirlanir");
        Console.WriteLine($"Balans: {person.Balance - margaritta.CalcPizzaPrice()}");
    }
}
else if (pizza.PizzaType == "Peperonni")
{

    Console.WriteLine("Kart melumatlarinizi daxil edin:");
    Console.WriteLine("Kart hesabinizi daxil edin:");
    person.CardNumber = Console.ReadLine();
    Console.WriteLine("Kart bitme muddetini  daxil edin:");
    person.ExpDate = Console.ReadLine();
    Console.WriteLine("Kart CVV ni daxil edin:");
    person.CVV = Console.ReadLine();

    if (person.CardNumber.Length == 16 && person.ExpDate.Length == 5 && person.CVV.Length == 3)
    {
        Peperonni peperonni = new Peperonni();
        Console.WriteLine("Pizzanin olcusun daxil edin:");
        peperonni.PizzaSize = Console.ReadLine();
        Console.WriteLine("Pizzaniz hazirlanir");
        Console.WriteLine($"Balans: {person.Balance - peperonni.CalcPizzaPrice()}");
    }
}



