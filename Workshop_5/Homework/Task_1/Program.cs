﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] array = new int [10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000); // генерируем случайное трехзначное число
    Console.Write($"{array[i]} ");
    
    if (array[i] % 2 == 0) // проверяем, является ли число четным
    {
        count++;
    }
}

Console.WriteLine($"\nКоличество четных чисел: {count}");
