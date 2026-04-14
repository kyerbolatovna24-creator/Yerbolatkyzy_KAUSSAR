task1
int[] numbers = { 3, 7, 2, 9, 5, 1 };

int sum = 0;
foreach (int n in numbers)
{
    sum += n;
}

Console.WriteLine($"Sum = {sum}");


int[] temps = { 12, -3, 45, 0, 28, -10, 33 };

Array.Sort(temps);
Console.WriteLine($"Min = {temps[0]}, Max = {temps[temps.Length - 1]}");


//task2
// int min = temps[0];
// int max = temps[0];

// foreach (int t in temps)
// {
//     min = Math.Min(min, t);
//     max = Math.Max(max, t);
// }

// Console.WriteLine($"Min = {min}, Max = {max}");

//task3
// string[] words = { "apple", "banana", "cherry", "date" };

// for (int i = 0; i < words.Length / 2; i++)
// {
//     string temp = words[i];
//     words[i] = words[words.Length - 1 - i];
//     words[words.Length - 1 - i] = temp;
// }

// Console.WriteLine(string.Join(" ", words));

//task4
// int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };

// int even = 0, odd = 0;

// foreach (int n in data)
// {
//     if (n % 2 == 0) even++;
//     else odd++;
// }

// Console.WriteLine($"Even = {even}, Odd = {odd}");

//task5
// int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };

// List<int> unique = new List<int>();

// foreach (int n in raw)
// {
//     if (!unique.Contains(n))
//         unique.Add(n);
// }

// Console.WriteLine(string.Join(" ", unique));


//task6
// int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
// int k = 3;

// int[] result = RotateLeft(arr, k);
// Console.WriteLine(string.Join(" ", result));

// static int[] RotateLeft(int[] arr, int k)
// {
//     int n = arr.Length;
//     int[] rotated = new int[n];

//     k = k % n;

//     for (int i = 0; i < n; i++)
//     {
//         rotated[i] = arr[(i + k) % n];
//     }

//     return rotated;
// }

//task7
// Console.WriteLine(IsPalindrome("madam"));   // true
// Console.WriteLine(IsPalindrome("hello"));   // false
// Console.WriteLine(IsPalindrome("racecar")); // true

// static bool IsPalindrome(string s)
// {
//     for (int i = 0; i < s.Length / 2; i++)
//     {
//         if (s[i] != s[s.Length - 1 - i])
//             return false;
//     }
//     return true;
// }

//task8
// Console.WriteLine(Factorial(5)); // 120

// static long Factorial(int n)
// {
//     long result = 1;

//     for (int i = 1; i <= n; i++)
//     {
//         result *= i;
//     }

//     return result;
// }

//task9
// for (int i = 1; i <= 20; i++)
// {
//     Console.WriteLine(FizzBuzz(i));
// }

// static string FizzBuzz(int n)
// {
//     if (n % 3 == 0 && n % 5 == 0) return "FizzBuzz";
//     if (n % 3 == 0) return "Fizz";
//     if (n % 5 == 0) return "Buzz";
//     return n.ToString();
// }

// task10
// double[] celsius = { 0, 20, 37, 100, -40 };

// foreach (double c in celsius)
// {
//     double f = ToFahrenheit(c);
//     Console.WriteLine($"{c}°C = {f}°F");
// }

// static double ToFahrenheit(double c)
// {
//     return c * 9 / 5 + 32;
// }

// static double ToCelsius(double f)
// {
//     return (f - 32) * 5 / 9;
// }