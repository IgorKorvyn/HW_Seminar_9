/* Решать через рекурсию!!! (НЕ ИСПОЛЬЗОВАТЬ РЕЗУЛЬТИРУЮЩУЮ ПЕРЕМЕННУЮ) 
Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


int ResultNumbers(int m, int n)
{
    if (n == m) return n;

    return n + ResultNumbers(m, n - 1);

}

Console.Clear();
Console.Write("Введите число 1-ое: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2-ое: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(($"Cумма натуральных элементов между числами = {ResultNumbers(m, n)}"));
