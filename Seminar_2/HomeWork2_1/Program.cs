﻿// программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число: ");
int n= Convert.ToInt32(Console.ReadLine());

int a1=(n%100);
int a2=a1/10;
Console.WriteLine($"Вторая цифра числа = {a2}");