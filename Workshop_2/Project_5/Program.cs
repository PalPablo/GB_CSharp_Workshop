// Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом
// другого.
// ● 5, 25 -> да
// ● -4, 16 -> да
// ● 25, 5 -> да
// ● 8,9 -> нет

// Console.Write("Введи первое число: ");
// int num1 = int.Parse(Console.ReadLine());

// Console.Write("Введи второе число: ");
// int num2 = int.Parse(Console.ReadLine());

// if (num1 * num1 == num2)
// {
//      Console.Write("да");
// }

// else if (num2 * num2 == num1)
// {
//     Console.Write("да");
// }

// else 
// {
//     Console.Write("нет");
// }

Console.WriteLine("введите число 1: ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("введите число 2: ");
int number2 = Convert.ToInt32 (Console.ReadLine());

if (number1 * number1 == number2  || number2 * number2 == number1) {
Console.WriteLine("да");
}
else {
Console.WriteLine("нет");
}
