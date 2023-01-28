/* Напишите программу, которая:
1. принимает на вход координаты двух точек
2. находит расстояние между ними в 2D пространстве.
Например:
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 
Квадрат гипотенузы равен сумме квадратов катетов
длинна = квадратный корень из ((x2-x1) в квадрате - (y2-y1) в квадрате)*/
Console.WriteLine("Введите координаты первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
double lengthSegment = LengthSegment(x1, y1, x2, y2);
Console.WriteLine($"Длинна отрезка: {lengthSegment} ");
double LengthSegment(int a1, int b1, int a2, int b2)
{
    double result = Math.Round(Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2)), 2, MidpointRounding.ToZero);
    return result;
}