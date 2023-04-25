// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();
Console.WriteLine("Enter number N: ");
int N = Convert.ToInt32(Console.ReadLine());
int multip = 1;
for (int i = 1; i <= N; i++)
{
    multip = multip * i;
}

Console.WriteLine($"Multiplication = {multip}");
