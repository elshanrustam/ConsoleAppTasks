
#region Test1
//int[] numbers = new int[5];
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write($"{i + 1}.No number : ");
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//int sum = 0;
//foreach (var number in numbers)
//{
//    sum += number;
//}
//Console.WriteLine(sum); 
#endregion

#region Test2(matrixlerin elementlerinin yazdirilmasi)

//int[,] matrixA = { 
//                   { 1, 2, 3 },
//                   { 4, 5, 6 } 
//                 };

//for (int i = 0; i < matrixA.GetLength(0); i++)
//{
//    for (int j = 0; j < matrixA.GetLength(1); j++)
//    {
//        Console.WriteLine($"matrixA[{i},{j}] = {matrixA[i, j]}");
//    }
//}
#endregion

#region Task3
//string[] students = new string[5];

//for (int i = 0; i < students.Length; i++)
//{
//    Console.Write($"{i+1}.No student name : ");
//    students[i] = Console.ReadLine();
//}
//Console.WriteLine("------------");
//foreach (string student in students)
//{
//    Console.WriteLine(student);
//}
#endregion

#region Task4
//int[] numbers = new int[5];
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write($"{i + 1}.No number : ");
//    numbers[i] = int.Parse(Console.ReadLine());
//}
//int sumEven = 0;
//int multiSingle = 1;
//foreach (int number in numbers)
//{
//    if (number % 2 == 0)
//    {
//        sumEven = sumEven + number;
//    }
//    else if (number % 2 == 1)
//    {
//        multiSingle = multiSingle * number;
//    }
//}

//Console.WriteLine($"Sum of even: {sumEven}");
//Console.WriteLine($"Multiplication of single: {multiSingle}");
#endregion

#region Task5(A array-nin en boyuk elementi ile B array-nin en kicik elementlerinin yerini deyis)

//int[] numbersA = new int[5] { 4, 6, -3, 44, -5 };
//int[] numbersB = { 9, 16, 100, 11, -20 };

//int maxA = numbersA[0];
//int maxIndexA = 0;
//for (int i = 1; i < numbersA.Length; i++)
//{
//    if (numbersA[i] > maxA)
//    {
//        maxIndexA = i;
//        maxA = numbersA[i];
//    }
//}
//Console.WriteLine($"numberA max deyeri : {maxA}");
//int minB = numbersB[0];
//int minIndexB = 0;
//for (int i = 1; i < numbersB.Length; i++)
//{
//    if (numbersB[i] < minB)
//    {
//        minIndexB = i;
//        minB = numbersB[i];
//    }
//}
//Console.WriteLine($"numberB min deyeri : {minB}");

//int temp = numbersB[minIndexB];
//numbersB[minIndexB] = numbersA[maxIndexA];
//numbersA[maxIndexA] = temp;
//Console.WriteLine("---------------");
//for (int i = 0; i < numbersA.Length; i++)
//{
//    Console.WriteLine($"numbersA-nin {i + 1}-ci elementi : {numbersA[i]}");
//}
//Console.WriteLine("---------------");
//for (int i = 0; i < numbersA.Length; i++)
//{
//    Console.WriteLine($"numbersB-nin {i + 1}-ci elementi : {numbersB[i]}");
//}

#endregion

#region Task6(matrixlerin vurulmasi)

//int[,] matrixA = { { 1, 2, 3 },
//                   { 4, 5, 6 } };

//int[,] matrixB = { { 7, 8 },
//                   { 9, 10 },
//                   { 11, 12 } };

//int rows1 = matrixA.GetLength(0);
//int cols1 = matrixA.GetLength(1);

//int rows2 = matrixB.GetLength(0);
//int cols2 = matrixB.GetLength(1);

//int[,] resultMatrix = new int[rows1, cols2];

//for (int i = 0; i < rows1; i++)
//{
//    for (int j = 0; j < cols2; j++)
//    {
//        int sum = 0;
//        for (int k = 0; k < cols1; k++)
//        {
//            sum += matrixA[i, k] * matrixB[k, j];
//        }
//        resultMatrix[i, j] = sum;
//    }
//}

//Console.WriteLine("Çarpım Sonucu:");
//for (int i = 0; i < rows1; i++)
//{
//    for (int j = 0; j < cols2; j++)
//    {
//        Console.Write(resultMatrix[i, j] + " ");
//    }
//    Console.WriteLine();
//}

#endregion

