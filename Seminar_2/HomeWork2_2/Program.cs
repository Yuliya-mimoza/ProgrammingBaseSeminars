// программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 999)
{
    number = number / 10;
}
    
if (number > 99)

{
    int n1 = number % 100;
    int n2 = n1 % 10;
    Console.WriteLine($"Третья цифра числа = {n2}");
}
else if (number < 100)
{
    Console.WriteLine($"Не верно введено число! Третья цифра отсутствует! ");
}