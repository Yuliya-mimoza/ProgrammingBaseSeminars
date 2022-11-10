// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int Vozvedenie(int a, int b)
{
    int rez=1;
    for (int i = 1; i <= b; i++)
    {
        rez = rez * a;
    }
    return rez;
}


Console.WriteLine("Введите число, А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа, В: ");
int b = Convert.ToInt32(Console.ReadLine());

int rez = Vozvedenie(a, b);
Console.WriteLine($"Число А в степени В = {rez}");