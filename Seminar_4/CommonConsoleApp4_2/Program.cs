// программа, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number=Convert.ToInt32(Console.ReadLine());

string strNumber = Math.Abs(number).ToString();
Console.WriteLine(strNumber.Length);
