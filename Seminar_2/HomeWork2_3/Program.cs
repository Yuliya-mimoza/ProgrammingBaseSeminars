// программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 | number > 7)
{
    Console.WriteLine("Номер дня недели введен не верно!");
}
 else
 if (number == 6 | number == 7)
 {
     Console.WriteLine("Этот день является выходным");
 }
else
{
    Console.WriteLine("Этот день НЕ является выходным"); 
}