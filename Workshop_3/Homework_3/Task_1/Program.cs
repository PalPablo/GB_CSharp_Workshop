// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введи пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstNumber = number / 10000;
int secondNumber = (number / 1000) % 10;
int fourthNumber = (number / 10) % 10;
int fifthNumber = number % 10;

if (firstNumber == fifthNumber && secondNumber == fourthNumber)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Это число не палиндром");
}
