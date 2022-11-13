// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.WriteLine("Сколько элементов будет в массиве? ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Текущий массив: ");
for (int i = 0; i < n; i++)
{
    Console.Write(array[i] + ", ");
}
Console.WriteLine();
Console.WriteLine("Новый массив: ");
if (n % 2 == 0)
{
    int[] newArray = new int[n / 2];
    for (int i = 0; i < (n / 2); i++)
    {
        newArray[i] = array[i] * array[n - 1 - i];
        Console.Write(newArray[i] + ", ");
    }
}
else
{
    int[] newArray = new int[n / 2 + 1];
    for (int i = 0; i < (n / 2 + 1); i++)
    {
        newArray[i] = array[i] * array[n - 1 - i];
        if (i == n / 2)
        {
            newArray[i] = array[i];
        }
        Console.Write(newArray[i] + ", ");
    }
}

/* ===Решение от Михаила===
Для массива с нечетным кол-вом элементов
if (array.Length % 2 == 1)
{
// Инициализация результирующего массива с заданной размерностью
resultArray = new int[(array.Length / 2) + 1];

// Подсчет произведения пар
for (int i = 0; i <= (resultArray.Length / 2 + 1); i++)
{
// Проверка на центральный элемент
if (i == (resultArray.Length / 2) + 1)
{
resultArray[i] = array[i];
}

// Произведение пар
resultArray[i] = array[i] * array[array.Length - i - 1];
}
}

return resultArray;
}

int[] arrayA = new int[4] { 6, 7, 3, 6};
int[] arrayB = new int[5] { 1, 2, 3, 4, 5};

int[] resultA = GetPairMult(arrayA);
int[] resultB = GetPairMult(arrayB);
*/ 