﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Clear();

// Console.Write("Введите значение N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// PrintNumbers(N);


// static void PrintNumbers(int n)
// {
//     if (n <= 0)
//         return;

//     Console.Write(n + " ");
//     PrintNumbers(n - 1);
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.Clear();

// Console.Write("Введите значение M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int sum = CalculateSum(M, N);

// Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N}: {sum}");


// static int CalculateSum(int start, int end)
// {
//     int sum = 0;

//     for (int i = start; i <= end; i++)
//     {
//         sum += i;
//     }

//     return sum;
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.WriteLine("Введите значение m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение n:");
int n = Convert.ToInt32(Console.ReadLine());

int result = AckermannFunction(m, n);

Console.WriteLine($"Значение функции Аккермана для m = {m} и n = {n}: {result}");


static int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
    else
    {
       
        throw new ArgumentException("Недопустимые значения аргументов m и n.");
    }
}


