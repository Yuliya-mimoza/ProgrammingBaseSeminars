// Программа, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (х и у).

// Получить диапазон координат
string DiapCoord(int num)
{
    string coord = " ";
    if (num == 1)
    {
        coord = "X > 0 и Y > 0";
    }
    if (num == 2)
    {
        coord = "X < 0 и Y > 0";
    }
    if (num == 3)
    {
        coord = "X < 0 и Y < 0";
    }
    if (num == 4)
    {
        coord = "X > 0 и Y < 0";
    }
    if (num < 1 || num > 4)
    {
        coord = "Не верно введен номер четверти! Введите номер четверти от 1 до 4! ";
    }
    return coord;
}

Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

string coord = DiapCoord(number);
Console.WriteLine($"Диапазон возможных координат: {coord}");
