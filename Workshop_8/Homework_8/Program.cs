// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] array = new int[,]
// {
//     { 1, 4, 7, 2 },
//     { 5, 9, 2, 3 },
//     { 8, 4, 2, 4 }
// };

// SortRowsDescending(array);

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// static void SortRowsDescending(int[,] array)
// {
//     int rowCount = array.GetLength(0);

//     for (int i = 0; i < rowCount; i++)
//     {
//         List<int> tempList = new List<int>();

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             tempList.Add(array[i, j]);
//         }

//         tempList.Sort((x, y) => y.CompareTo(x));

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = tempList[j];
//         }
//     }
// }



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


//     int[,] array = new int[,]
//     {
//         { 1, 4, 7, 2 },
//         { 5, 9, 2, 3 },
//         { 8, 4, 2, 4 },
//         { 5, 2, 6, 7 }
//     };

//     Console.WriteLine("Исходный массив:");
//     PrintArray(array);

//     int minRowIndex = FindRowWithMinimumSum(array);

//     Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex + 1}");


// static int FindRowWithMinimumSum(int[,] array)
// {
//     int rowCount = array.GetLength(0);
//     int columnCount = array.GetLength(1);

//     int[] rowSums = new int[rowCount];


//     for (int i = 0; i < rowCount; i++)
//     {
//         int rowSum = 0;

//         for (int j = 0; j < columnCount; j++)
//         {
//             rowSum += array[i, j];
//         }

//         rowSums[i] = rowSum;
//     }

//     int minRowIndex = 0;
//     int minRowSum = rowSums[0];

//     for (int i = 1; i < rowCount; i++)
//     {
//         if (rowSums[i] < minRowSum)
//         {
//             minRowIndex = i;
//             minRowSum = rowSums[i];
//         }
//     }

//     return minRowIndex;
// }

// static void PrintArray(int[,] array)
// {
//     int rowCount = array.GetLength(0);
//     int columnCount = array.GetLength(1);

//     for (int i = 0; i < rowCount; i++)
//     {
//         for (int j = 0; j < columnCount; j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

