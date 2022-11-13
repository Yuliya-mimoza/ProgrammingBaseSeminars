// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Sum ( int[] array)
{
    int sum=0;
    for (int i=0; i<array.Length;i++)
    {
        if (i%2!=0)
        sum=sum+array[i];
    }
    return sum;
}
Console.WriteLine("Сколько элементов будет в массиве? ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
Console.WriteLine("Текущий массив: ");
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-100, 101);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int rez=Sum(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {rez}");
