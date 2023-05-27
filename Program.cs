// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int Prompt (string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int result = Math.Abs(Convert.ToInt32(value));
//     return result;
// }

// int[] CreateRandomArray (int size)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(100, 1000);
//     }
//     return newArray;
// }

// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// void PositiveNum (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }
//     Console.WriteLine();
//     Console.WriteLine($"The number of positive numbers in the array -> {count}");
// }

// int size = Prompt ("Input size array: ");
// int[] newArray = CreateRandomArray(size);

// PrintArray(newArray);
// PositiveNum(newArray);

 

//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int result = Math.Abs(Convert.ToInt32(value));
//     return result;
// }

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");    
//     }
// }

// int SumNumOddPosition (int[] array)
// {
//     int sumOddNum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0) sumOddNum = sumOddNum + array[i];
//     }
//     return sumOddNum;
// }

// int size = Prompt("Input size array: ");
// int minValue = Prompt("Input minimal value: ");
// int maxValue = Prompt("Input maximal value: ");

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// int sum = SumNumOddPosition(myArray);

// Console.WriteLine();
// Console.WriteLine(sum);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int Prompt (string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int result = Math.Abs(Convert.ToInt32(value));
//     return result;
// }

// void PrintArray (double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// double[] CreateRandomDoubleArray (int size)
// {
//     double[] newArray = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().NextDouble() + new Random().Next();
//     }
//     return newArray;
// }

// double DiffMaxMin (double[] array)
// {
//     double maxNum = array[0];
//     double minNum = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < minNum)  minNum = array[i];
//         if (array[i] > maxNum)  maxNum = array[i];
//     }
//     return maxNum - minNum;
// }

// int size = Prompt("Input size array: ");
// double[] myArray = CreateRandomDoubleArray (size);

// PrintArray(myArray);
// double result = DiffMaxMin (myArray);

// Console.WriteLine();
// Console.WriteLine($"The difference between the maximum and minimum values of the array -> {result}");



