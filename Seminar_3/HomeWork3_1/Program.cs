// программа, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// Вычисление расстояния между взятыми двумя точками в 3D пространстве
double Distance(int x1, int y1, int z1,int x2, int y2,int z2)
{
    double length1 = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2)+Math.Pow(z2 - z1,2));
    return length1;
}

Console.WriteLine("Введите X первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double length = Distance(x1, y1, z1,x2, y2,z2);
Console.WriteLine($"Расстояние между взятыми на плоскости двумя точками = {length}");