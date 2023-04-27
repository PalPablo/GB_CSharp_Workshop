// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = new int[5];
int [] array2 = new int [array.Length/2+array.Length%2];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 5);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i < array2.Length; i++)
{
    if (i == array.Length-i-1) 
    {
        array2[i] = array[i];
    }
    else
    {
        array2[i] = array[i] * array [array.Length-i-1];
    }
    Console.Write ($"{array2[i]} ");
    
}
