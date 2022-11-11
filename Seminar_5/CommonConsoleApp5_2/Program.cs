// Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] array = new int[10] { 5, 8, 6, 13, 47, 9, 15, 16, 0, -19 }; 

Console.Write("Начальный массив: ");
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i]+" ");
}
Console.WriteLine();

Console.Write("Массив наоборот: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * (-1);
    Console.Write(array[i]+" ");
}
