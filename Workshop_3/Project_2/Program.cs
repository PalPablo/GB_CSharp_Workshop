// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти  ");
int N4 = Convert.ToInt32(Console.ReadLine());

if(N4 == 1)
{
  Console.WriteLine ("X>0, Y>0");
}
else if (N4 == 2)
{
  Console.Write("X<0, Y>0");
}
else if (N4 == 3)
{
  Console.Write("X<0, Y<0");
}
else if (N4 == 4)
{
  Console.Write("X>0, Y<0");
}
else if (N4 > 4 || N4 < 1)
{
  Console.Write("такой четверти нет");
}

