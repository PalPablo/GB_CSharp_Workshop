//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberToText = Convert.ToString(number);
if (numberToText.Length > 2){
  Console.WriteLine($"Третья цифра {numberToText[2]}");
}
else {
  Console.WriteLine("Третьей цифры нет");
}


