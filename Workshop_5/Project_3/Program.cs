// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[5];
string result = "такого значения нет";

for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 5);
Console.Write(array[i]);
  if (array[i] == N)
{
    result = "такое значение есть";
}
}
Console.WriteLine(result);
