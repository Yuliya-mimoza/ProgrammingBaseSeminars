﻿// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая запишет нулями строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 0 0 0 0
// 0 9 4 2
// 0 2 2 6
// 0 3 4 7
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                array[i, j] = new Random().Next(1, 101);
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                Console.Write(String.Format("{0,5}",array[i, j]));
            }
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
Console.WriteLine("Мы получили массив: ");
FillArray(array);
Console.WriteLine();
int mini = 0;
int minj = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[mini, minj] > array[i, j])
        {
            mini = i;
            minj = j;
        }
    }
}
Console.Write(array[mini, minj]);
for (int i = 0; i < array.GetLength(0); i++)
{
    array[i, minj] = 0;
}
for (int j = 0; j < array.GetLength(1); j++)
{
    array[mini, j] = 0;
}
Console.WriteLine();
PrintArray(array);