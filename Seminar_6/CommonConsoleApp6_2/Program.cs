// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
string Proverka(int a1, int a2, int a3)
{
    string rezalt = " ";
    if ((a1 < a2 + a3) && (a2 < a1 + a3) && (a3 < a1 + a2))
    {
        rezalt = ($"Такой треугольник может существовать");
    }
    else
    {
        rezalt = ($"Такого треугольника не существует");
    }
    return rezalt;
}

Console.WriteLine("Введите длину 1 стороны треугольника");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину 2 стороны треугольника");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину 3 стороны треугольника");
int a3 = Convert.ToInt32(Console.ReadLine());
string rezalt = Proverka(a1, a2, a3);
Console.WriteLine(rezalt);