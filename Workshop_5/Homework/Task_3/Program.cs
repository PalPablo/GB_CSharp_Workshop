// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int[] array = { 2, 5, 1, 8, 4, 7, 3 };

int max = array[0];
int min = array[0];

foreach (int num in array)
{
    {
        Console.Write(num);
    }

    if (num > max)
    {
        max = num;
    }
    else if (num < min)
    {
        min = num;
    }
}

int diff = max - min;
Console.WriteLine();


Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");