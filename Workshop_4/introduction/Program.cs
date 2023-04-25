// Функции

// void SayLang(string lang)
// {
//     Console.WriteLine($"Привет {lang}!!!");
// }

// SayLang("Python");
// Console.WriteLine ("1");
// SayLang("Java");
// Console.WriteLine ("2");
// string lang1 = "C++";
// SayLang(lang1);


// void SayLang(int num1, int num2)
// {
//     if (num1 > num2)
//         Console.WriteLine($"Привет {num1}!!!");
//     else
//         Console.WriteLine($"Привет {num2}!!!");
// }

// SayLang(1, 2);
// Console.WriteLine("1");
// SayLang(3, 1);
// Console.WriteLine("2");

// SayLang(7, 5);


int SayLang(int num1, int num2)
{
    if (num1 > num2)  
        return num1;
    else
        return num2;
}

Console.WriteLine(SayLang(1, 2));

int x = SayLang(3, 1);
Console.WriteLine ($"Привет, {x}!!!");  

int y = SayLang(7, 5) * 10;
Console.WriteLine ($"Привет, {y}!!!");
