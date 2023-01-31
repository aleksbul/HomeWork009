// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Ackerman(n - 1, 1);
    else return Ackerman(n - 1, Ackerman(n, m - 1));
}
int n = 2;
int m = 3;
Ackerman(n, m);

Console.WriteLine($"n = {n}, m = {m} -> A({n}, {m}) = {Ackerman(n, m)}");