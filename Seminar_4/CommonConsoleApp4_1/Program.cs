// программа, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetSum(int number)
{
    int sum = 0;

    // используя "WHILE"

    /*int tempValue=1;
    while (tempValue<=number)
    {
        sum=sum+tempValue;
        tempValue++;
    }*/

    // используя "FOR"

    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    
    return sum;
}

Console.WriteLine("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = GetSum(number);
Console.WriteLine($"Сумма = {sum}");