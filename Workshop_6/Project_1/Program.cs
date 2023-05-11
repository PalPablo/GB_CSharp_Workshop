// Задача 39. Напишите программу, которая перевернет одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int Prompt(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int[] CreateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

int[] ReverseArray(int[] rearray)
{
    int x = 0;
    int i = 1;
    while (i < rearray.Length / 2)
    {
        x = rearray[i];
        rearray[i] = rearray[rearray.Length - 1 - i];
        rearray[rearray.Length - 1 - i] = x;
        i++;
    }
    return rearray;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}


int length = Prompt("Enter length ");
int min = Prompt("Enter minimal count ");
int max = Prompt("Enter maximum count ");
int[] massive = CreateArray(length, min, max);
PrintArray(massive);
massive = ReverseArray(massive);
PrintArray(massive);

