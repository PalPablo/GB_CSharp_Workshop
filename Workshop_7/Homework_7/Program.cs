// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int m = 3; 
// int n = 4; 

// double[,] array = new double[m, n];

// Random random = new Random(); 


// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = random.NextDouble(); 
//     }
// }


// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write($"{array[i, j]} "); 
//     }
//     Console.WriteLine(); 
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


        // int[,] array = {
        //     { 1, 2, 3 },
        //     { 4, 5, 6 },
        //     { 7, 8, 9 }
        // };

        // Console.Write("Введите индекс строки: ");
        // int row = int.Parse(Console.ReadLine());

        // Console.Write("Введите индекс столбца: ");
        // int column = int.Parse(Console.ReadLine());

        // if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
        // {
            
        //     int value = array[row, column];
        //     Console.WriteLine($"Значение элемента: {value}");
        // }
        // else
        // {
        //     Console.WriteLine("Указанная позиция не существует.");
        // }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        
        for (int j = 0; j < columns; j++)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }
            double average = (double)sum / rows;
            Console.WriteLine($"Среднее арифметическое столбца {j + 1}: {average}");
        }

