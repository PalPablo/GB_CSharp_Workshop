﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = new int[10];
int sum = 0;

// Заполнение массива случайными числами от 1 до 20
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 21);
    Console.Write($"{array[i]} ");
}
 Console.WriteLine();

// Нахождение суммы элементов, стоящих на нечётных позициях
for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");