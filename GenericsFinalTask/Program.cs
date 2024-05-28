using GenericsFinalTask.Classes;
using GenericsFinalTask.Helpers;
using GenericsFinalTask.Managers;
using static System.Console;




start:
WriteLine("1.Mushteri");
WriteLine("2.Ishci");
WriteLine("-----------");
Write("Sechin:");
int chooseNumber = int.Parse(ReadLine());

switch (chooseNumber)
{
    case (int)UserTypes.Mushteri:
        Menu.GetAllMenu();
        break;
    case (int)UserTypes.Ishci:
        WriteLine("1.Menyu \n" +
            "2.Silmek \n" +
            "3.Elave etmek \n" +
            "4.Deyisdirmek ");
        Write("Sechin:");
        int chooseOperation = int.Parse(ReadLine());

        switch (chooseOperation)
        {
            case (int)Operations.GetAll:
                Menu.GetAllMenu();
                break;
            case (int)Operations.Remove:

                WriteLine("1.Desert silin");
                WriteLine("2.Icki silin");
                WriteLine("3.Fast-food silin");
                WriteLine("4.Yemek silin");
                Write("Silinecek erzaqi sechin: ");
                int deletedOperation = int.Parse(ReadLine());
                switch (deletedOperation)
                {
                    case 1:
                        Write("Desert Index: ");
                        int desertIndex = int.Parse(ReadLine());
                        DesertManager deleteDesert = new DesertManager();
                        deleteDesert.Remove(desertIndex);
                        WriteLine($"{desertIndex + 1} Id-li desert ugurla silindi");
                        break;
                    case 2:
                        Write("Icki Index: ");
                        int drinkIndex = int.Parse(ReadLine());
                        DrinkManager deleteDrink = new DrinkManager();
                        deleteDrink.Remove(drinkIndex);
                        WriteLine($"{drinkIndex + 1} Id-li icki ugurla silindi");
                        break;
                    case 3:
                        Write("Fast-food Index: ");
                        int fastFoodIndex = int.Parse(ReadLine());
                        FastFoodManager deleteFastFood = new FastFoodManager();
                        deleteFastFood.Remove(fastFoodIndex);
                        WriteLine($"{fastFoodIndex + 1} Id-li fast-food ugurla silindi");
                        break;
                    case 4:
                        Write("Yemek Index: ");
                        int mealIndex = int.Parse(ReadLine());
                        MealManager deleteMeal = new MealManager();
                        deleteMeal.Remove(mealIndex);
                        WriteLine($"{mealIndex + 1} Id-li yemek ugurla silindi");
                        break;

                    default:
                        WriteLine("Duzgun secim edin!");
                        break;
                }
                WriteLine("Davam etmek isteyirsen? /he");
                string response = ReadLine().ToLower();
                if (response == "he")
                {
                    goto start;
                }
                else
                {
                    break;
                }
            case (int)Operations.Add:
                WriteLine("1.Desert elave et");
                WriteLine("2.Icki elave et");
                WriteLine("3.Fast-food elave et");
                WriteLine("4.Yemek elave et");
                Write("Elave edilecek erzaqi sechin: ");
                int addedOperation = int.Parse(ReadLine());
                switch (addedOperation)
                {
                    case 1:
                        DesertManager addDesert = new DesertManager();

                        int desertId = addDesert.GetAll().Count();
                        Write("Desert Adi: ");
                        string desertName = ReadLine();
                        Write("Desert Qiymeti: ");
                        int desertPrice = int.Parse(ReadLine());
                        Write("Desert Indgrientleri: ");
                        string desertIndrigient = ReadLine();
                        addDesert.Add(new Desert { Id = desertId + 1, Name = desertName, Price = desertPrice, Indrigient = desertIndrigient });
                        WriteLine("Desert elave edildi.");
                        foreach (var addedDesert in addDesert.GetAll())
                        {
                            WriteLine($"Id: {addedDesert.Id},Name: {addedDesert.Name},Price: {addedDesert.Price},Indigirentler: {addedDesert.Indrigient}");
                        }

                        break;
                    case 2:
                        DrinkManager addDrink = new DrinkManager();

                        int drinkId = addDrink.GetAll().Count();
                        Write("Icki Adi: ");
                        string drinkName = ReadLine();
                        Write("Icki Qiymeti: ");
                        int drinkPrice = int.Parse(ReadLine());
                        addDrink.Add(new Drink { Id = drinkId, Name = drinkName, Price = drinkPrice });
                        WriteLine("Icki elave edildi.");
                        foreach (var addedDrink in addDrink.GetAll())
                        {
                            WriteLine($"Id: {addedDrink.Id + 1},Name: {addedDrink.Name},Price: {addedDrink.Price}");
                        }

                        break;
                    case 3:
                        FastFoodManager addFastFood = new FastFoodManager();

                        int fastFoodId = addFastFood.GetAll().Count();
                        Write("Fast-food Adi: ");
                        string fastFoodName = ReadLine();
                        Write("Fast-food Qiymeti: ");
                        int fastFoodPrice = int.Parse(ReadLine());
                        addFastFood.Add(new FastFood { Id = fastFoodId, Name = fastFoodName, Price = fastFoodPrice });
                        WriteLine("Fast-food elave edildi.");
                        foreach (var addedFastFood in addFastFood.GetAll())
                        {
                            WriteLine($"Id: {addedFastFood.Id + 1},Name: {addedFastFood.Name},Price: {addedFastFood.Price}");
                        }

                        break;
                    case 4:
                        MealManager addMeal = new MealManager();

                        int mealId = addMeal.GetAll().Count();
                        Write("Yemek Adi: ");
                        string mealName = ReadLine();
                        Write("Yemek Qiymeti: ");
                        int mealPrice = int.Parse(ReadLine());
                        Write("Yemek Indgrientleri: ");
                        string mealIndrigient = ReadLine();
                        addMeal.Add(new Meal { Id = mealId, Name = mealName, Price = mealPrice, Indrigient = mealIndrigient });
                        WriteLine("Yemek elave edildi.");
                        foreach (var addedMeal in addMeal.GetAll())
                        {
                            WriteLine($"Id: {addedMeal.Id + 1},Name: {addedMeal.Name},Price: {addedMeal.Price},Indigrentleri: {addedMeal.Indrigient}");
                        }

                        break;


                    default:
                        WriteLine("Duzgun secim edin!");
                        break;
                }


                WriteLine("Davam etmek isteyirsen? /he");
                string answer = ReadLine().ToLower();
                if (answer == "he")
                {
                    goto start;
                }
                else
                {
                    break;
                }
            case (int)Operations.Update:
                WriteLine("1.Desert deyisdir");
                WriteLine("2.Icki deyisdir");
                WriteLine("3.Fast-food deyisdir");
                WriteLine("4.Yemek deyisdir");
                Write("Deyisdirilecek erzaqi sechin: ");
                int updateOperation = int.Parse(ReadLine());
                switch (updateOperation)
                {
                    case 1:
                        DesertManager updateDesert = new DesertManager();

                        Write("Desert Id: ");
                        int desertId = int.Parse(ReadLine());
                        Write("Desert Adi: ");
                        string desertName = ReadLine();
                        Write("Desert Qiymeti: ");
                        int desertPrice = int.Parse(ReadLine());

                        updateDesert.Update(desertId, new Desert { Name = desertName, Price = desertPrice, });
                        foreach (var item in updateDesert.GetAll())
                        {
                            WriteLine($"Id:{item.Id},Name:{item.Name},Price:{item.Price}");
                        }
                        break;
                    case 2:
                        DrinkManager updateDrink = new DrinkManager();

                        Write("Icki Id: ");
                        int drinkId = int.Parse(ReadLine());
                        Write("Icki Adi: ");
                        string drinkName = ReadLine();
                        Write("Icki Qiymeti: ");
                        int drinkPrice = int.Parse(ReadLine());

                        updateDrink.Update(drinkId, new Drink { Name = drinkName, Price = drinkPrice, });
                        foreach (var item in updateDrink.GetAll())
                        {
                            WriteLine($"Id:{item.Id},Name:{item.Name},Price:{item.Price}");
                        }
                        break;
                    case 3:
                        FastFoodManager updateFastFood = new FastFoodManager();

                        Write("Fast food Id: ");
                        int fastFoodId = int.Parse(ReadLine());
                        Write("Fast food Adi: ");
                        string fastFoodName = ReadLine();
                        Write("Fast food Qiymeti: ");
                        int fastFoodPrice = int.Parse(ReadLine());

                        updateFastFood.Update(fastFoodId, new FastFood { Name = fastFoodName, Price = fastFoodPrice, });
                        foreach (var item in updateFastFood.GetAll())
                        {
                            WriteLine($"Id:{item.Id},Name:{item.Name},Price:{item.Price}");
                        }
                        break;
                    case 4:
                        MealManager updateMeal = new MealManager();

                        Write("Yemek Id: ");
                        int maelId = int.Parse(ReadLine());
                        Write("Yemek Adi: ");
                        string mealName = ReadLine();
                        Write("Yemek Qiymeti: ");
                        int mealPrice = int.Parse(ReadLine());

                        updateMeal.Update(maelId, new Meal { Name = mealName, Price = mealPrice, });
                        foreach (var item in updateMeal.GetAll())
                        {
                            WriteLine($"Id:{item.Id},Name:{item.Name},Price:{item.Price}");
                        }
                        break;


                    default:
                        break;
                }

                WriteLine("Davam etmek isteyirsen? /he");
                string choose = ReadLine().ToLower();
                if (choose == "he")
                {
                    goto start;
                }
                else
                {
                    break;
                }
            default:
                WriteLine("Bele bir emeliyyat yoxdur");
                break;
        }
        break;


    default:
        WriteLine("Yanlish secim yeniden secin.");
        goto start;
}

