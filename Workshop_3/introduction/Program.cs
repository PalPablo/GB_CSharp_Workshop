string f1 = "Anna";
string f2 = "Bob";
string f3 = "Tamara";
string f4 = "Stanislav";
string f5 = "Bakhytzhan";

string[] f = {"Anna", "Bob", f3, f4, f5};

Console.WriteLine(f[1]);

f[1] = "Maya";

Console.WriteLine(f[1]);

Console.WriteLine(f.Length);


// Console.WriteLine(f.Length);
int number = 10;

int[] nums1 = {1, 4, 6, 7, 9};
int[] nums2 = new int[number];

// int[] nums1 = new int[5] {1, 4, 6, 7, 9};
// int[] nums1 = new int[] {1, 4, 6, 7, 9};
// int[] nums1 = new[] {1, 4, 6, 7, 9};

for (int i = 0; i < nums2.Length; i++)
{
    Console.Write($"{nums2[i]} ");
}

Console.WriteLine();
Console.Write($"{nums2} ");

