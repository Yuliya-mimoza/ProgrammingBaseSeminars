//  Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                array[i, j] = new Random().Next(1, 10);
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanColumn(int[,] array, int m)
{
    double AM = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            AM += array[i, j];
        }
        Console.Write($"Среднее арифметическое каждого столбца: = {AM / m}");
        AM = 0;
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
ArithmeticMeanColumn(array, m);
