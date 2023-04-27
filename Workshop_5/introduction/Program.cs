string s = "1, 2, 3, 4, 5, 6, 7.";
Console.WriteLine(s);

string[] nums = s.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);

int[] n = nums.Select(Int32.Parse).ToArray();

foreach (var num in nums)
{
   Console.WriteLine($" Значение {num}");
}

int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
