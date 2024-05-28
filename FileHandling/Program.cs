
using FileHandling.Classes;
using System.Net.Security;






#region Task1
////string path = @"C:\Users\elsha\OneDrive\Documents\UniserITAcademy";
////string newFolderPath = Path.Combine(path, "UniserWorkers.txt");
//File.Create(newFolderPath);
//Console.WriteLine(newFolderPath);

////Employee employee = new Employee();
////List<Employee> employees = new List<Employee>()
////{
////    new Employee{employeeName="Elshan",employeeSurname="Rustamzada",salary = 500},
////    new Employee{employeeName="Qurban",employeeSurname="Qurbanov",salary = 1500},
////    new Employee{employeeName="Tebriz",employeeSurname="Letifov",salary = 2000},
////    new Employee{employeeName="Orxan",employeeSurname="Memmedov",salary = 200},
////};

////List<string> employeersInfo = new List<string>();
////foreach (var employeer in employees)
////{
////    employeersInfo.Add($"{employeer.employeeId},{employeer.employeeName},{employeer.employeeSurname},{employeer.salary}");
////}

////File.AppendAllLines(newFolderPath, employeersInfo);

//string[] lines = File.ReadAllLines(newFolderPath);

////foreach (var line in lines)
////{
////    Console.WriteLine(line);
////}

//Console.Write("Enter the word: ");
//string searchingWord = Console.ReadLine();
//List<string> output = new List<string>();

//if (File.Exists(newFolderPath))
//{
//    foreach (string line in lines)
//    {
//        if (line.Contains(searchingWord))
//        {
//            output.Add(line);
//        }
//    }
//}
//else
//{
//    Console.WriteLine("This file does not exist.");
//}

//foreach (string item in output)
//{
//    Console.WriteLine(item);
//} 
#endregion

#region Task2(searching file)
//Console.WriteLine("Folderin adin daxil edin: ");
//string folderName = Console.ReadLine();
//Console.WriteLine("Faylin adin daxil edin: ");
//string fileName = Console.ReadLine();

//string secondPath = $@"C:\Users\elsha\OneDrive\Documents\{folderName}\{fileName}";

//if (File.Exists(secondPath))
//{
//    Console.WriteLine("Exists");
//}
//else
//{
//    Console.WriteLine("does not exist");
//} 
#endregion

#region Task3(file encryption)
string path = @"C:\Users\elsha\OneDrive\Documents\UniserITAcademy\";
string inputFile = @"C:\Users\elsha\OneDrive\Documents\UniserITAcademy\UniserWorkers.txt";

string outputPath = Path.Combine(path, "OutputFile.txt");
//File.Create(outputPath);

int key = 2;

Encryption(inputFile, outputPath, key);
void Encryption(string inputFile, string outputfile, int key)
{
    byte[] inputBytes = File.ReadAllBytes(inputFile);
    for (int i = 0; i < inputBytes.Length; i++)
    {
        inputBytes[i] = (byte)(inputBytes[i] * key);
    }
    File.WriteAllBytes(outputfile, inputBytes);
    Console.WriteLine("Operation completed");
}
#endregion




