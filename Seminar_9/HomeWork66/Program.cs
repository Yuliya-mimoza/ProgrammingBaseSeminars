// // Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumMN(int m, int n)
{
    int sum = 0;
    sum += m;

    if (m == n)
    {
        return sum;
    }
    return sum + SumMN(m + 1, n);
}
int SumNM(int n, int m)
{
    int sum = 0;
    sum += n;
    if (m == n)
    {
        return sum;
    }
    return sum + SumNM(n + 1, m);
}

Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m <= n)
{
    Console.WriteLine($"Сумма элементов от {m} до {n} равна: {SumMN(m, n)}");
}
else
if (m > n)
{
    Console.WriteLine($"Сумма элементов от {m} до {n} равна:{SumNM(n, m)}");
}