// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите размер строк массива");
// int QuantityLines = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размер колонок массива");
// int QuantityColumns = Convert.ToInt32(Console.ReadLine());

// void FillArrayRandomRealNumbersInt(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArrayInt(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

// void SortingArrayDesc (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int a = 0; a < array.GetLength(1) - 1; a++)
//       {
//         if (array[i, a] < array[i, a + 1])
//         {
//           int temp = array[i, a + 1];
//           array[i, a + 1] = array[i, a];
//           array[i, a] = temp;
//         }
//       }
//     }
//   }
// }

// void ShowSortedArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// int[,] array = new int[QuantityLines, QuantityColumns];

// FillArrayRandomRealNumbersInt(array);

// Console.WriteLine();
// PrintArrayInt(array);

// Console.WriteLine($"\nУпорядоченный по убыванию массив: ");
// SortingArrayDesc (array);
// ShowSortedArray(array);

//////////////////////////////////////////////////////////////////////////////////////////

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите размер строк массива");
// int QuantityLines = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размер колонок массива");
// int QuantityColumns = Convert.ToInt32(Console.ReadLine());

// void FillArrayRandomRealNumbersInt(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArrayInt(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

// int[,] array = new int[QuantityLines, QuantityColumns];

// int FindSumLine(int[,] array, int i)
// {
//   int sum = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sum += array[i,j];
//   }
//   return sum;
// }

// FillArrayRandomRealNumbersInt(array);

// Console.WriteLine();
// PrintArrayInt(array);

// int minSum = 0;
// int sum = FindSumLine(array, 0);

// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int temp = FindSumLine(array, i);
//   if (sum > temp)
//   {
//     sum = temp;
//     minSum = i;
//   }
// }

// Console.WriteLine($"\nСтрокa с наименьшей суммой - {minSum+1}");






