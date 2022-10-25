// Программа, которая принимает на вход координаты точки (Х и У), 
// причем х и у не равно 0 и выдает номер четверти в плоскости, в которой находится эта точка. 

//<возвращ.тип данных> <наименование метода>(переменные){тело метода}
// Получить номер четверти на плоскости 
int GetPointArea(int coordX, int coordY)
{
    int numberArea = 0;
    if (coordX > 0 && coordY > 0)
    {
        numberArea = 1;
    }
    if (coordX < 0 && coordY > 0)
    {
        numberArea = 2;
    }
    if (coordX < 0 && coordY < 0)
    {
        numberArea = 3;
    }
    if (coordX > 0 && coordY < 0)
    {
        numberArea = 4;
    }
    return numberArea;
}

Console.WriteLine("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int numberArea = GetPointArea(x, y);
Console.WriteLine($"Номер четверти: {numberArea}");