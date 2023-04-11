// Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого
// числа.
// ● 456 -> 46
// ● 782 -> 72
// ● 918 -> 98 8

int n = new Random().Next(100, 1000); 
Console.WriteLine($"Случайное число: {n}");

int result = (n / 100 * 10) + (n % 10);

Console.WriteLine(result);

// int number = new Random().Next(100, 1000);
// int number1 = number / 100;
// int number2 = number % 100 / 10; 
// int number3 = number % 10;
// Console.WriteLine($"{number1}"); 
// Console.WriteLine($"{number2}"); 
// Console.WriteLine($"{number3}"); 
// Console.WriteLine($"{number}"); 
// Console.WriteLine($"{number1 * 10 + number3}");


