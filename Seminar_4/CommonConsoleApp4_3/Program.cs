// программа, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


int GetPr (int number)
{
    int pr=1;
for (int i=1; i<=number;i++)
{
    pr=pr*i;
}
return pr;
}

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int pr=GetPr(number);
Console.WriteLine($"произведение чисел от 1 до {number} = {pr}");
