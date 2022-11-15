// 69 task через функцию

/* Console.Clear();
Console.Write("Введите число A  : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень B: ");
int n = Convert.ToInt32(Console.ReadLine());
int num_n = num;    //число, возведенное в степень
for (int i = 1; i < n; i++)
{
    num_n = num_n * num;
}
Console.Write("число A в степени B = ");
Console.WriteLine(num_n); */

string ResultNumbers(int m, int n)
{
    if (n == m)
        return $"{m}";
    return ResultNumbers(m, n - 1) + ", " + Convert.ToString(n);
}


Console.Clear();
Console.Write("Введите число 1-ое: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2-ое: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ResultNumbers(m, n));