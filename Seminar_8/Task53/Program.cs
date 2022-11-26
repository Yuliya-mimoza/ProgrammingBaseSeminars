// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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

void ReplacementArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                temp = array[i, j];
                array[i, j] = array[array.GetLength(0) - 1, j];
                array[array.GetLength(0) - 1, j] = temp;
                Console.Write(array[i, j] + " ");

            }
            else
            {
                Console.Write(array[i, j] + " ");
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
ReplacementArray(array);