/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("Введи первое число ");
int num_1 = int.Parse(Console.ReadLine());

Console.Write("Введи второе число ");
int num_2 = int.Parse(Console.ReadLine());

Console.Write("Введи третье число ");
int num_3 = int.Parse(Console.ReadLine());

int maxNum = num_1;

if (num_2 > maxNum) {
    maxNum = num_2;
}

if (num_3 > maxNum) {
    maxNum = num_3;
}

Console.WriteLine("max = " + maxNum);