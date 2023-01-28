/* Напишите программу, которая:
1. принимает на вход координаты двух точек
2. находит расстояние между ними в 3D пространстве.
Например:
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.WriteLine("Введите координаты первой точки: ");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double lengthSegment = LengthSegment(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Длинна отрезка: {lengthSegment} ");
double LengthSegment(int xa1, int ya1, int za1, int xa2, int ya2, int za2)
{
    return Math.Round(Math.Sqrt(Math.Pow((xa2 - xa1), 2) + Math.Pow((ya2 - ya1), 2) + Math.Pow((za2 - za1), 2)), 2, MidpointRounding.ToZero);
}
