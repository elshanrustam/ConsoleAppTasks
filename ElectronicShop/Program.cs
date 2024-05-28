

using ElectronicShop.Classes;
using ElectronicShop.Managers;



PhoneManager phoneManager = new PhoneManager(new Phone { Marc = "Samsung", Model = "Note 11", Price = 2000, CameraMegaPixels = 64, OperatingSystem = "Android" });
phoneManager.CalcPriceWithTax();
phoneManager.DisplayInfo();
phoneManager.CheckCamera();