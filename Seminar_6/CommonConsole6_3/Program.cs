// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

string Perevod(int chislo)
{
    int rez = 0;
    string str = " ";
    while (chislo != 0)
    {
        rez = chislo % 2;
        chislo = chislo / 2;
        str = rez + str;
    } 
    return str;
}

Console.WriteLine("Введите число в десятичной системе: ");
int chislo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Данное число будет выглядеть в двоичной системе исчисления вот так: ");
string str = Perevod(chislo);
Console.WriteLine($"{str}");