


#region Task1-Mentor
//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine($"2-nin {i}-ci quvveti -- {Math.Pow(2,i)}");
//}
//for (int i = 1; i <= 7; i++)
//{
//    Console.WriteLine($"3-un {i}-ci quvveti -- {Math.Pow(3, i)}");
//}
#endregion

#region Task2-Mentor
//int number = 5;
//int factorialOfNumber = 1;
//int i = 1;
//while (i <= number)
//{
//    factorialOfNumber = factorialOfNumber * i;
//    Console.WriteLine($"{i}-nin faktoriali {factorialOfNumber}");
//    i++;
//} 
#endregion

#region Task3-Mentor
//int factorialOfNumber = 1;
//for (int i = 1; i <= 5; i++)
//{
//    factorialOfNumber = factorialOfNumber * i;
//    Console.WriteLine($"{i}-nin faktoriali {factorialOfNumber}");
//}
#endregion

#region Task4-Mentor
//int number = int.Parse(Console.ReadLine());
//int faktorielNumber = 1;
//for (int i = 1; i <= number; i++)
//{
//    faktorielNumber *= i;
//}
//Console.WriteLine($"Faktorial : {faktorielNumber}");
#endregion

#region Task5(Daxil edilen ededin reqemlerinin cemini tap)
//Console.Write("Enter the Number : ");
//int number = int.Parse(Console.ReadLine());
//int sum = 0, reminder;

//while (number > 0)
//{
//    reminder = number % 10;
//    sum = sum + reminder;
//    number = number / 10;
//}

//Console.WriteLine($"The Sum of Digits is : {sum}");
//Console.ReadKey();
#endregion

#region Task6
//string simvol = "*";
//for (int i = 1; i <= 4; i++)
//{
//    Console.WriteLine(simvol);
//    simvol += "*";
//} 
#endregion

#region Task7
//int i = 1;
//int count = 0;
//int sum = 0;
//while (i < 30)
//{
//    if (i % 3 == 0 && i % 2 == 0)
//    {
//        count++;
//        sum += i;
//    }
//    i++;

//}

//WriteLine($"Count : {count}");
//WriteLine($"Sum : {sum}");
#endregion

#region Task8
//decimal multiple = 1;
//for (int i = 1; i < 50; i += 3)
//{
//    multiple = multiple * i;
//}
//Console.WriteLine(multiple); 
#endregion

#region Task9
//int sum = 0;
//int multiple = 1;
//for (int i = -30; i < 28; i++)
//{
//    if (i % 3 == 0 && i % 6 == 0)
//    {
//        sum = sum + i;
//    }
//    if (i % 5 == 0 || i % 2 == 0)
//    {
//        multiple = multiple * i;
//    }
//}

//Console.WriteLine($"Sum : {sum}");
//Console.WriteLine($"Multiplaction : {multiple}"); 
#endregion

#region Task10
//int number = 304001;
//int sum = 0, reminder;
//int count = 0;
//while (number > 0)
//{
//    reminder = number % 10;
//    sum = sum + reminder;
//    number = number / 10;
//    if (reminder != 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"Sum : {sum}");
//Console.WriteLine($"Count : {count}"); 
#endregion

#region Task11
//int number = 4573;
//int remainder = 0;
//while (number > 0)
//{
//    remainder = number % 10;
//    Console.Write(remainder);
//    number = number / 10;
//} 
#endregion

#region Task12(login and password system)

//string correctLogin = "elshan";
//string correctPassword = "6142";

//int maxAttempts = 3;
//int attempts = 0;
//while (attempts < maxAttempts)
//{
//    string login = Console.ReadLine();
//    string password = Console.ReadLine();

//    if (correctLogin == login && correctPassword == password)
//    {
//        Console.WriteLine("Sisteme daxil oldunuz!");
//        break;
//    }
//    else if (correctLogin != login && correctPassword != password)
//    {
//        attempts++;
//        Console.WriteLine("Her ikisi sefdir!");
//    }
//    else if (correctLogin != login)
//    {
//        attempts++;
//        Console.WriteLine("Login sefdir!");
//    }
//    else if (correctPassword != password)
//    {
//        attempts++;
//        Console.WriteLine("Password sefdir!");
//    }

//}
//if (attempts == maxAttempts)
//{
//    Console.WriteLine("System bloklanmisdir!");
//}
#endregion

#region Task13(do-while)
//Console.Write("Type your password : ");
//string password;
//do
//{
//    password = Console.ReadLine();
//} while (password != "uni123");
#endregion

#region Vurma cedveli
for (int i = 1; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j} = {i * j}");
    }
    Console.WriteLine("-------------");
}
#endregion


