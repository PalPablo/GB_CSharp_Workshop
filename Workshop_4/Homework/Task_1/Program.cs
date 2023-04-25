// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введи первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 0; i < num2; i++)
{
    result = result * num1;
}

Console.WriteLine($"{num1} в степени {num2} равно {result}");