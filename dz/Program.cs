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

//////////////////////////////////////////////////////////////////////////////////////////
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

// int size = 2;

// int[,] matrixA = new int[size, size];
// int[,] matrixB = new int[size, size];

// FillArrayRandomRealNumbersInt(matrixA);
// FillArrayRandomRealNumbersInt(matrixB);

// int[,] matrixC = new int[size, size];

// for (int i = 0; i < size; i++)
// {
//     for (int j = 0; j < size; j++)
//     {
//         for (int a = 0; a < size; a++)
//         {
//             matrixC[i, j] = matrixC[i, j] + (matrixA[i, a] * matrixB[a, j]);
//         }
//     }
// }
// Console.WriteLine("Матрица 1");
// PrintArrayInt(matrixA);
// Console.WriteLine();
// Console.WriteLine("Матрица 2");
// PrintArrayInt(matrixB);
// Console.WriteLine();
// Console.WriteLine("Произведение матриц 1 и 2");
// PrintArrayInt(matrixC);



//////////////////////////////////////////////////////////////////////////////////////////
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array = new int[2, 2, 2];

// void PrintArrayAndIndex(int[,,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// void FillArrayInt(int[,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }

// FillArrayInt(array);
// PrintArrayAndIndex(array);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int size = 4;
// int[,] number = new int[size, size];

// void FillArraySpiral(int[,] number, int n)
// {
//     int i = 0, j = 0;
//     int value = 1;
//     for (int a = 0; a < n * n; a++)
//     {
//         int b = 0;
//         do { number[i, j++] = value++; } while (++b < n - 1);
//         for (b = 0; b < n - 1; b++) number[i++, j] = value++;
//         for (b = 0; b < n - 1; b++) number[i, j--] = value++;
//         for (b = 0; b < n - 1; b++) number[i--, j] = value++;
//         ++i; ++j;
//         n = n < 2 ? 0 : n - 2;
//     }
// }

// void PrintArrayInt(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10)
//             {
//                 Console.Write("0" + array[i, j]);
//                 Console.Write(" ");
//             }
//             else Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// FillArraySpiral(number, size);
// PrintArrayInt(number);