// See  Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

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

void PrintElement(int[,] array, int x, int y)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == x - 1 && j == y - 1)
            {
                Console.Write($"Искомый элемент равен = {array[i, j]}");
            }
        }
    }
}

Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
Console.WriteLine("Мы получили массив: ");
FillArray(array);
Console.WriteLine("Введите позицию искомого элемента по строкам: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию искомого элемента по столбцам: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > m || y > n || x <= 0 || y <= 0)
{
    Console.WriteLine("Элемента с такой позицией нет");
}
else
{
    PrintElement(array, x, y);
}