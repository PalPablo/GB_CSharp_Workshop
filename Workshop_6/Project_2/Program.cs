//Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Write("Введи число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// string dvoichnoeChislo = "";

// while (x > 0)
// {
//     if (x % 2 == 0)
//     {
//         dvoichnoeChislo = "0" + dvoichnoeChislo;
//     }
//     else
//         dvoichnoeChislo = "1" + dvoichnoeChislo;
//     x = x / 2;
// }
// Console.WriteLine(dvoichnoeChislo);

Console.Write("Введи число: ");
int x = Convert.ToInt32(Console.ReadLine());
string dvoichnoeChislo = "";

while (x > 0)
{

        dvoichnoeChislo = Convert.ToString(x % 2)+ dvoichnoeChislo;
    x = x / 2;
}
Console.WriteLine(dvoichnoeChislo);