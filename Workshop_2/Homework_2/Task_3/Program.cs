﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

// Console.Write("Введи цифру, обозначающую день недели: ");
// int num = int.Parse(Console.ReadLine());

// if (num == 6 || num == 7)
// {
//     Console.Write($"{num} является выходным днем");
// }

// else 
// {
//     Console.Write($"{num} не является выходным днем");
// }


Console.Write("Введи цифру, обозначающую день недели: ");
int num = int.Parse(Console.ReadLine());

if (num < 1 || num > 7) {
    Console.WriteLine("Такого дня недели не существует");
}
else if (num >=1 && num < 6){
Console.WriteLine("Это будний день");
}
else
{
    Console.WriteLine("Это выходной день");
}



