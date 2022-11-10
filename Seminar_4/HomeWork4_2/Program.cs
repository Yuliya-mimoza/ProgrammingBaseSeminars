// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumaFigure(int a)
{
    int sum = 0;
    int length = Math.Abs(a).ToString().Length;
    
    for (int i = 1; i <= length; i++)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
}

Console.WriteLine("Введите число, А: ");
int a = Convert.ToInt32(Console.ReadLine());

int sum = SumaFigure(a);
Console.WriteLine($"Сумма цифр в числе равна: {Math.Abs(sum)}");

