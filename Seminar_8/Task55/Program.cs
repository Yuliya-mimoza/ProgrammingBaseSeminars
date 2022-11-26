// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
    for (int j = 0; j < array.GetLength(1); j++)
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            //array[i, j] = array[j, i];
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк равных количеству столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов в массиве: ");
//int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, m];
Console.WriteLine("Мы получили массив: ");
FillArray(array);
Console.WriteLine();
ReplacementArray(array);