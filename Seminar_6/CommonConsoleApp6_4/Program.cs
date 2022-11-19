// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число N больше 2: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] fibo = new int[n];

if (n < 3)
{
    Console.WriteLine("Введите число N больше 2: ");
}
else
{
    fibo[0] = 0;
    fibo[1] = 1;
    Console.Write($"{fibo[0]}, ");
    Console.Write($"{fibo[1]}, ");
    for (int i = 2; i < fibo.Length; i++)
    {
        fibo[i] = fibo[i - 1] + fibo[i - 2];
        Console.Write($"{fibo[i]}, ");
    }
}

/*  ============ Вариант 2 =================
int n = 7;

int f1 = 0;
int f2 = 1;
int f3 = 0;

Console.Write("0 1 ");

for (int i = 2; i < n; i++)
{
f3 = f1 + f2;
Console.Write(f3 + " ");
f1 = f2;
f2 = f3;
}
*/
