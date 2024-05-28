

#region Task1(Pul cekme emeliyyati)
//int Mebleg = 1000;

//int emeliyyatNomresi = int.Parse(Console.ReadLine());
//switch (emeliyyatNomresi)
//{
//    case 1:
//        Console.WriteLine("Pul cekme emeliyyati");
//        Console.WriteLine("siz 1-50,2-100,3-150 manat ceke bilersiniz");
//        Console.Write("Cekilecek meblegi secin:  ");
//        int cekilecekMebleg = int.Parse(Console.ReadLine());
//        int sonHesab = 0;
//        switch (cekilecekMebleg)
//        {
//            case 1:
//                Console.WriteLine("50 manat cekilecek");
//                sonHesab = Mebleg - 50;
//                Console.WriteLine($"Hesabiniz: {sonHesab}");
//                break;
//            case 2:
//                Console.WriteLine("100 manat cekilecek");
//                sonHesab = Mebleg - 100;
//                Console.WriteLine($"Hesabiniz: {sonHesab}");
//                break;
//            case 3:
//                Console.WriteLine("150 manat cekilecek");
//                sonHesab = Mebleg - 150;
//                Console.WriteLine($"Hesabiniz: {sonHesab}");
//                break;
//            default:
//                Console.WriteLine("Bele bir mebleg ceke bilmersiniz...");
//                break;
//        }
//        break;
//    case 2:
//        Console.WriteLine("Pul kocurme emeliyyati");
//        Console.WriteLine("1-113pinli hesab");
//        Console.WriteLine("2-109pinli hesab");
//        Console.WriteLine("3-101pinli hesab");
//        Console.Write("Pul kocurelec hesabi secin:  ");

//        int hesabNomresi = int.Parse(Console.ReadLine());
//        switch (hesabNomresi)
//        {
//            case 1:
//                Console.WriteLine("113 nomreli hesaba pul kocuruldu");
//                break;
//            case 2:
//                Console.WriteLine("109 nomreli hesaba pul kocuruldu");
//                break;
//            case 3:
//                Console.WriteLine("101 nomreli hesaba pul kocuruldu");
//                break;
//            default:
//                Console.WriteLine("Bazada bele bir hesab yoxdu");
//                break;
//        }
//        break;
//    case 3:
//        Console.WriteLine($"Hesabiniz: {Mebleg}");
//        break;
//    case 4:
//        Console.WriteLine("Cixis edilir...");
//        break;
//    default:
//        Console.WriteLine("Bele bir emeliyyat movcud deyil");
//        break;
//}
#endregion

#region Task2(Restaran proqrami)
//Console.WriteLine("Restaranimiza xosh gelmisiniz...");
//Console.Write("Hesabi daxil edin:  ");

//double orderTotal = double.Parse(Console.ReadLine());
//if (orderTotal >= 100)
//{
//    Console.WriteLine("Musterinin statusunu daxil edin:  ");
//    string customerStatus = Console.ReadLine().ToLower();
//    int discount = 0;
//    switch (customerStatus)
//    {
//        case "gold":
//            discount = 20;
//            Console.WriteLine($"Size {discount} faiz endirim tetbiq olunur");
//            break;
//        case "silver":
//            discount = 15;
//            Console.WriteLine($"Size {discount} faiz endirim tetbiq olunur");

//            break;
//        case "bronze":
//            discount = 10;
//            Console.WriteLine($"Size {discount} faiz endirim tetbiq olunur");

//            break;
//        default:
//            discount = 5;
//            Console.WriteLine($"Size {discount} faiz endirim tetbiq olunur");

//            break;
//    }

//    Console.WriteLine($"Sizin endirimsiz hesabiniz {orderTotal}");
//    orderTotal = orderTotal - orderTotal * discount / 100;
//    Console.WriteLine($"Endirim tetbiq olunmus hesabiniz {orderTotal}");
//}
//else
//{
//    Console.WriteLine("Endirim 100 manati kecmis hesablara aid edilir");
//}
#endregion

#region Task3(Bank proqrami)

//int[] hesablarim = { 1200, 1300, 2400, 5000 };
//start:
//Console.WriteLine("Bankomata xosh gelmisiniz...");
//Console.WriteLine("Emeliyyatlarimiz bunlardir:");
//Console.WriteLine("1.Hesablar haqqinda melumat");
//Console.WriteLine("2.Pul kocurme");
//Console.WriteLine("3.Cixish etmek");

//Console.WriteLine("Etmek istediyiniz emeliyyati daxil edin");
//Console.Write("Emeliyyat: ");
//int emeliyyatNomresi = int.Parse(Console.ReadLine());

//switch (emeliyyatNomresi)
//{
//    case 1:
//        foreach (int Hesab in hesablarim)
//        {
//            Console.WriteLine($"{Array.IndexOf(hesablarim, Hesab) + 1}.No hesabda {hesablarim[Array.IndexOf(hesablarim, Hesab)]} - meblegh var.");
//        }
//        Console.WriteLine("Davam etmek isteyirsiniz?");
//        Console.Write("Cavabinizi daxil edin: ");
//        string cavab = Console.ReadLine().ToLower();
//        if (cavab == "he")
//        {
//            goto start;
//        }
//        else if (cavab == "yox")
//        {
//            goto end;
//        }
//        else
//        {
//            Console.WriteLine("Duzgun cavab verin...");
//        }
//        break;
//    case 2:
//        Console.WriteLine("Pul kocurme emeliyyati");
//        Console.WriteLine("Zehmet olmasa pul kocurelecek hesabin nomresini daxil edin");
//        Console.Write("Pul kocurelecek Hesab: ");
//        int kocurulecekHesabNomresi = int.Parse(Console.ReadLine());

//        Console.WriteLine("Pul cixarilacaq hesabin nomresini daxil edin");
//        Console.Write("Pul cixarilacaq Hesab: ");
//        int cixarilacaqHesabNomresi = int.Parse(Console.ReadLine());

//        Console.WriteLine("Mebleghi daxil edin");
//        Console.Write("Kocurulecek meblegh: ");
//        int meblegh = int.Parse(Console.ReadLine());

//        if (hesablarim[cixarilacaqHesabNomresi - 1] < meblegh)
//        {
//            Console.WriteLine("Hesabda yeteri qeder meblegh yoxdur.");
//        }
//        else
//        {
//            Console.WriteLine($"Siz {cixarilacaqHesabNomresi}.No hesabdan {meblegh} qeder mebleghi " + $"{kocurulecekHesabNomresi}.No hesaba kocurme emeliyyati edirsiniz...");
//            Console.WriteLine($"{cixarilacaqHesabNomresi}.No hesabda balans: {(hesablarim[cixarilacaqHesabNomresi - 1]) - meblegh}" + "\n" +$"{kocurulecekHesabNomresi}.No hesabda balans: {(hesablarim[kocurulecekHesabNomresi - 1]) + meblegh}");
//        }
//        break;
//    case 3:
//        end:
//        Console.WriteLine("Cixish edilir...");
//        break;
//    default:
//        Console.WriteLine("Bele bir emeliyyat yoxdur...");
//        break;
//} 
#endregion

#region Task4(Menu system)
//WriteLine("1.Isti yemekler");
//WriteLine("2.Qazan yemekleri");
//WriteLine("3.Ickiler");
//WriteLine("4.Desertler");
//Write("Secdiyiniz menyunun nomresini daxil edin: ");
//int menuNumber = int.Parse(ReadLine());
//switch (menuNumber)
//{
//    case 1:
//        WriteLine("1-Dolma");
//        WriteLine("2-Kartof");
//        WriteLine("3-Saurma");
//        WriteLine("4-Kabab");
//        Write("Secdiyiniz yemeyin nomresi: ");
//        int eatNumber = int.Parse(ReadLine());
//        switch (eatNumber)
//        {
//            case 1:
//                WriteLine("Dolma sifaris edildi");
//                break;
//            case 2:
//                WriteLine("Kartof sifaris edildi");
//                break;
//            case 3:
//                WriteLine("Saurma sifaris edildi");
//                break;
//            case 4:
//                WriteLine("Kabab sifaris edildi");
//                break;
//            default:
//                WriteLine("Hal-hazirda ele yemek novu yoxdu");
//                break;
//        }
//        break;
//    case 2:
//        WriteLine("1-As");
//        WriteLine("2-Sous");
//        WriteLine("3-Sup");
//        WriteLine("4-Kaklet");
//        Write("Secdiyiniz qazan yemeyinin nomresi: ");
//        int kettleNumber = int.Parse(ReadLine());
//        switch (kettleNumber)
//        {
//            case 1:
//                WriteLine("As sifaris edildi");
//                break;
//            case 2:
//                WriteLine("Sous sifaris edildi");
//                break;
//            case 3:
//                WriteLine("Sup sifaris edildi");
//                break;
//            case 4:
//                WriteLine("Kaklet sifaris edildi");
//                break;
//            default:
//                WriteLine("Hal-hazirda ele qazan yemeyi novu yoxdu");
//                break;
//        }
//        break;
//    case 3:
//        WriteLine("1-Cola");
//        WriteLine("2-Fanta");
//        WriteLine("3-Sprite");
//        WriteLine("4-Ayran");
//        Write("Secdiyiniz ickinin nomresi: ");
//        int drinkNumber = int.Parse(ReadLine());
//        switch (drinkNumber)
//        {
//            case 1:
//                WriteLine("Cola sifaris edildi");
//                break;
//            case 2:
//                WriteLine("Fanta sifaris edildi");
//                break;
//            case 3:
//                WriteLine("Sprite sifaris edildi");
//                break;
//            case 4:
//                WriteLine("Ayran sifaris edildi");
//                break;
//            default:
//                WriteLine("Hal-hazirda ele icki novu yoxdu");
//                break;
//        }
//        break;
//    case 4:
//        WriteLine("1-Tort");
//        WriteLine("2-Popkek");
//        WriteLine("3-Pirojna");
//        WriteLine("4-Marojna");
//        Write("Secdiyiniz desertin nomresi: ");
//        int dessertNumber = int.Parse(ReadLine());
//        switch (dessertNumber)
//        {
//            case 1:
//                WriteLine("Tort sifaris edildi");
//                break;
//            case 2:
//                WriteLine("Popkek sifaris edildi");
//                break;
//            case 3:
//                WriteLine("Pirojna sifaris edildi");
//                break;
//            case 4:
//                WriteLine("Marojna sifaris edildi");
//                break;
//            default:
//                WriteLine("Hal-hazirda ele icki novu yoxdu");
//                break;
//        }
//        break;
//    default:
//        WriteLine("Zehmet olmasa duzgun menu nomresi daxil edin");
//        break;
//}
#endregion

