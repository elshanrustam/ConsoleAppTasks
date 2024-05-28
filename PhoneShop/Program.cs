
using PhoneShop.Classes;




Console.WriteLine("Melumatlarinizi daxil edin:");
Console.Write("Adinizi daxil edin: ");
string name = Console.ReadLine();
Console.Write("Soyadinizi daxil edin: ");
string surname = Console.ReadLine();
Console.Write("Balans daxil edin: ");
int balans = int.Parse(Console.ReadLine());

Person person = new Person();
person.Surname = surname;
person.Name = name;
person.Balance = balans;

Console.WriteLine($"\n Sizin adiniz: {person.Name} \n Soyadiniz: {person.Surname} \n balansiniz: {person.Balance}");

Iphone iphone = new Iphone();
iphone.PhoneName = "Iphone";
iphone.PhoneModel = "Iphone 11";
iphone.CompanyName = "Apple";
iphone.Price = 2000;

if (iphone.Price > person.Balance)
{
    Console.WriteLine("Balansinizda kifayet qeder mebleg yoxdur");
}
else
{
    Console.WriteLine("Emeliyyatiniz ugurla yerine yetirildi");
    Console.WriteLine($"Balansiniz: {person.Balance = person.Balance - iphone.Price}");
}

Xiaomi xiaomi = new Xiaomi();
xiaomi.PhoneName = "Xiaomi";
xiaomi.PhoneModel = "Xiaomi Note 11";
xiaomi.CompanyName = "Redmi";
xiaomi.Price = 1000;

if (xiaomi.Price > person.Balance)
{
    Console.WriteLine("Balansinizda kifayet qeder mebleg yoxdur");
}
else
{
    Console.WriteLine("Emeliyyatiniz ugurla yerine yetirildi");
    Console.WriteLine($"Balansiniz: {person.Balance = person.Balance - xiaomi.Price}");
}

