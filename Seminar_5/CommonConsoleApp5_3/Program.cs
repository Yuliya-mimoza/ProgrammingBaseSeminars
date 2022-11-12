// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

bool Search(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine("Сколько элементов будет в массиве? ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    Console.Write(array[i] + ", ");
}
Console.WriteLine();
Console.WriteLine("Какое число будем искать? ");
int number = Convert.ToInt32(Console.ReadLine());

bool rezalt = Search(array, number);
Console.WriteLine($"{rezalt} ");