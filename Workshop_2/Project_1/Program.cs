// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшуюцифру числа.
// Например:
// ● 78 -> 8
// ● 12-> 2
// ● 85 -> 8

int number = new Random().Next(1, 100); // Случайное число на отрезке [10, 99]
Console.WriteLine($"Случайное число: {number}"); // ("Случайное число:" + number);


int firstDigit = number / 10;
int secondDigit = number % 10; 

if (firstDigit > secondDigit) 
{
	Console.WriteLine(firstDigit);
}
else
{
	Console.WriteLine(secondDigit);
}

// for (int i = 0; i < 20; i++)
// {
//     int number = new Random().Next(10, 100);
//     int n1 = number / 10;
//     int n2 = number % 10;
//     if (n1 > n2)
//     {
//         Console.WriteLine($"{number} -> {n1}");
//     }
//     else
//     {
//        Console.WriteLine($"{number} -> {n2}"); 
//     }

// }

