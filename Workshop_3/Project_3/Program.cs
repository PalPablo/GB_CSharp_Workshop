// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// «Расстояние» d = √ [(x2-x1)2+ (y2-y1)2 ] , Где  (x1,y1) и (x2,y2) две точки на плоскости xy.

Console.WriteLine("Введите X первой точки ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y первой точки ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X второй точки ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y второй точки ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2)),2));
