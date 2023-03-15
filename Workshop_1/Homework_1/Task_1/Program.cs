/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Введи первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введи второе число: ");
int num2 = int.Parse(Console.ReadLine());

int maxNum;

if (num1 > num2) {
   maxNum = num1;
}

else {
     maxNum = num2;
}

Console.WriteLine("max = " + maxNum);
