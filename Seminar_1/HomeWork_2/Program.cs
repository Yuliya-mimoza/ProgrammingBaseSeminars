// программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int a3 = Convert.ToInt32(Console.ReadLine());
int max=a1;

if (max<a2) max=a2;
{
    if (max<a3) max=a3;
}
Console.WriteLine($"Максимальное число: {max}");