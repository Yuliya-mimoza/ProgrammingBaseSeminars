// программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Проверка на палиндром
string PalidromProverka(int n)
{
    string proverka = " ";
    int a1, a2, a4, a5 = 0;

    a1 = n / 10000;
    a2 = (n / 1000) % 10;
    a4 = (n % 100) / 10;
    a5 = n % 10;
    if (a1 == a5 && a2 == a4)
    {
        proverka = "Число является палиндромом ";
    }
    else
    {
        proverka = "Число НЕ является палиндромом ";
    }
    return proverka;
}

Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 10000 || n > 99999)
{
    Console.WriteLine("Вы НЕ ВЕРНО ввели число! Введите пятизначное число! ");
}
else
{
    string proverka = PalidromProverka(n);
    Console.WriteLine(proverka);
}