﻿// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно
// 7 и 23.
// ● 14 -> нет
// ● 46 -> нет
// ● 161 -> да

// Console.Write("Введи число: ");
// int num1 = int.Parse(Console.ReadLine());

// if (num1 % 7 == 0 && num1 % 23 == 0)
// {
//     Console.Write("Да");
// }
// else
// {
//     Console.Write("Нет");
// }

Console.Write("Введи число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 7 == 0 && num1 % 23 == 0)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
