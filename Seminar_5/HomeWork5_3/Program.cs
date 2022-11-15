// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

double Raznica(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine($"min = {min}, max = {max}");
    double rezalt = max - min;
    return rezalt;
}

Console.WriteLine("Сколько элементов будет в массиве? ");
int n = Convert.ToInt32(Console.ReadLine());

double[] array = new double[n];
Console.WriteLine("Текущий массив: ");
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-100, 101);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
double rezalt = Raznica(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {rezalt}");