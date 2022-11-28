// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                array[i, j] = new Random().Next(1, 101);
                Console.Write(String.Format("{0,3}", array[i, j]));
            }
        }
        Console.WriteLine();
    }
}
void ProductOfMatricesArray(int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                array[i, j] += array1[i, k] * array2[k, j];
            }
            Console.Write(String.Format("{0,5}", array[i, j] + " "));
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк в 1 массиве = количеству столбцов во 2 массиве: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в 1 массиве: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк во 2 массиве: ");
int m2 = Convert.ToInt32(Console.ReadLine());
int n2 = m1;

int[,] array1 = new int[m1, n1];
int[,] array2 = new int[m2, n2];

Console.WriteLine("Массив №1: ");
FillArray(array1);
Console.WriteLine("Массив №2: ");
FillArray(array2);
Console.WriteLine("Произведение двух матриц: ");
ProductOfMatricesArray(array1, array2);