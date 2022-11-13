// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int Counter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.WriteLine("Сколько элементов будет в массиве? ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
Console.WriteLine("Текущий массив: ");
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int count = Counter(array);
Console.WriteLine($"Количество чётных чисел в массиве: {count} ");