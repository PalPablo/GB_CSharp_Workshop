﻿// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// ● 34, 5 -> не кратно, остаток 4
// ● 16, 4 -> кратно

// int n = new Random().Next(1, 100); 

Console.Write("Введи первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введи второе число: ");
int num2 = int.Parse(Console.ReadLine());

int rem = num1 % 10;

if (num1 % num2 != 0)
{
    Console.Write(rem);
}

else 
{
    Console.Write("кратно");
}