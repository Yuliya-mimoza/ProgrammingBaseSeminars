// программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите целое число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа диапазона: " );
int i = 1;

while (i <= n)
{
    if (i % 2 == 0) Console.WriteLine(i);
    i = i + 1;
}