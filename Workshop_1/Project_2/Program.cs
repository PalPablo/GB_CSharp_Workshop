/*Задача №1. Напишите программу, которая на вход
принимает два числа и проверяет, является ли первое
число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет*/

Console.Write("Введи первое число: ");
int number_a = int.Parse(Console.ReadLine());

Console.Write("Введи второе число: ");
int number_b = int.Parse(Console.ReadLine());

int number_a_sqr = number_a * number_a;

if (number_a_sqr == number_b) {
Console.Write("Квадрат первого числа равен второму числу");
}

else {
Console.Write("Квадрат первого числа не равен второму числу");    
}