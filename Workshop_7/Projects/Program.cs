// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4 
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);

int[,] nums = new int[m, n];

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = new Random().Next(1, 100);
        Console.Write($"{nums[i, j]} ");
    }
    Console.WriteLine();
}

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
//  Aₘₙ = m+n. Выведите полученный массив на экран. 
//  m = 3, n = 4. 
//  0 1 2 3
//  1 2 3 4
//  2 3 4 5

// Console.Write("Введите число м: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m ,n ];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = i + j;
//         Console.Write(matrix[i,j] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// Console.Write("Введите число м: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m, n];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(1, 100);
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)
//         {matrix[i, j] = Convert.ToInt32(Math.Pow(matrix[i, j], 2));}
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.Write("Введите число м: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[m, n];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(1, 100);
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// int summ = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
        
//         if (i == j)
//         { summ = summ + matrix[i, j]; }
       
//     }
    
// }
// Console.WriteLine($"Сумма чисел по диагонали = {summ}");

// То же самое через методы

// int[,] CreateMatrix(int m, int n) //метод создания массива
// {
//     int[,] matrix = new int[m, n];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 100);
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }


// int SummDiagonal(int[,] matrix) //метод подсчета цифр по диагонали
// {
//     int summ = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             if (i == j)
//             { summ = summ + matrix[i, j]; }

//         }

//     }
//     return summ;
// }


// Console.Write("Введите число м: ");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n1 = Convert.ToInt32(Console.ReadLine());

// int[,] matr = CreateMatrix(m1, n1);
// int sum1 = SummDiagonal(matr);

// Console.WriteLine($"Сумма чисел по диагонали = {sum1}");
