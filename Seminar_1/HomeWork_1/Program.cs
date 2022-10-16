// программа, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int a2 = Convert.ToInt32(Console.ReadLine());

if (a1 > a2)
{
    Console.WriteLine($"Первое число: {a1} больше второго: {a2}");
}
else
{
    Console.WriteLine($"Второе число: {a2} больше первого: {a1}");
}