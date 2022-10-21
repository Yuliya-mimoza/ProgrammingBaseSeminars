// программа, которая принимает на вход два числа и выводит, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
    Console.WriteLine($"Второе число кратно первому числу");
}
else
{
    Console.WriteLine($"Второе число НЕ кратно первому числу, остаток = {number1 % number2}");
}