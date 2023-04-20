/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

// Console.Write("Введи число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Все четные числа от 1 до {N}: ");

// int num = 1;
// while (num <= N)
// {
//     if (num % 2 == 0)
//     {
//         Console.WriteLine(num);
//     }
//     num++;
//     }


Console.Write("Введи число: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Все четные числа от 1 до {N}:");

for (int i = 1; i <= N; i++)
    if (i % 2 == 0) 
Console.WriteLine(i);



// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine());

// for (int i = 1; i <= N; i++)
//     if (i % 2 == 0)
//         Console.WriteLine(i);