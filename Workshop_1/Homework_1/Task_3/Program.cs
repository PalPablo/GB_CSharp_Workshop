﻿/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Введи число: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"{num} -> четное");
}

else 
{
    Console.WriteLine($"{num} -> нечетное");
}

// Console.Write("Введи число: ");
// int num = int.Parse(Console.ReadLine());

// if (num % 2 == 1){
//     Console.Write("Число не четное");
// }
// else {
//     Console.Write("Число четное");
// }