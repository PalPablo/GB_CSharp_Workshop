// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введи трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 100;
int number2 = number % 100 / 10;
int number3 = number % 10;
if (number > 100 && number <= 999)
{
    Console.WriteLine($"{number}");
    Console.WriteLine($"{number2}");
}

else
{
    Console.WriteLine($"{number} не является трехзначным числом");
}






