﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();
int[] array = new int[12];
int result = 0;
int resultneg = 0;
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(-9, 10);
  Console.Write($"{array[i]} ");
  if (array[i] > 0)
  {
    result = result + array[i];
  }
  else
  {
    resultneg = resultneg + array[i];
  }
}
Console.WriteLine($"{result} и {resultneg}");
