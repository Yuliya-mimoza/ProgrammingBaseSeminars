// Задача 62: Заполните спирально массив 4 на 4.
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write((String.Format("{0,3}", array[i, j])));
        }
        Console.WriteLine();
    }
}

int n = 4;
int[,] spiralArray = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
{
    spiralArray[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
        j--;
    else
        i--;
}

FillArray(spiralArray);