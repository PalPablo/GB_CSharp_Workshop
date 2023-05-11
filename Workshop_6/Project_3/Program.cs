// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые 2 числа Фибоначчи 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1 
// Если N = 7 -> 0 1 1 2 3 5 8



Console.Write("Введи число: ");
int x = Convert.ToInt32(Console.ReadLine());

int [] massiv = new int[x];
massiv[0] = 0;
massiv[1] = 1;
for (int i = 2; i < x; i++)
{
    massiv[i] = massiv[i - 1] + massiv [i - 2];
}
foreach (int i in massiv)
Console.Write(i + "__"); 