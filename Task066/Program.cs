// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

int Sum(int m, int n)
{
    if (m > n) return n + Sum(m, n + 1);
    else if (m < n) return m + Sum(m + 1, n);
    return m;
}

Console.WriteLine(Sum(m, n));
