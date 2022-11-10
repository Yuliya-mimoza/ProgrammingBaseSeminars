// программа, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int Perevod(int number)
{
    int length = 0;
    string strNumber = Math.Abs(number).ToString();
    length = strNumber.Length;
    return length;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int length = Perevod(number);
Console.WriteLine(length);