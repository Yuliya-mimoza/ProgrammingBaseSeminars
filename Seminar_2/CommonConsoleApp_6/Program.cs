﻿// программа, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2 || number2 == number1 * number1)
{
    Console.WriteLine("Одно число является квадратом другого ");
}
else
    Console.WriteLine("Одно число НЕ является квадратом другого");