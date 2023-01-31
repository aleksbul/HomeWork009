// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

string Numbers(int n)
{
    if (n >= 1) return $"{n} " + Numbers(n - 1);
    else return String.Empty;
}
Console.WriteLine(Numbers(n));