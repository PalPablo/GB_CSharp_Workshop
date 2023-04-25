// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int lenth = 1;
while (num > 9)
{
    num = num / 10;
    lenth++;
}
Console.WriteLine($"Ответ: {lenth}");
