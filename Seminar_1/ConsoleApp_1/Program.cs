// Напишите программу, которая на вход принимает целое число и выдает его квадрат
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);
int sqrnumber = number * number;
Console.Write($"Квадрат числа = {sqrnumber}");