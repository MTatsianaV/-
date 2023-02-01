/* Напишите программу, которая:
1. найдёт точку пересечения двух прямых, заданных уравнениями:
    y = k1*x+b1
    y = k2*x+b2
2. Значения b1, b2, k1, k2 задаются пользователем.
Например:
b1=2, k1=5, b2=4, k2=9 -> (-0.5; -0.5) */
Console.WriteLine("Введите значения:");
Console.Write("b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2:");
int k2 = Convert.ToInt32(Console.ReadLine());
double PointOfIntersectionX(int xB1, int xB2, int xK1, int xK2)
{
    return Convert.ToDouble(xB2 - xB1) / (xK1 - xK2);
}
double PointOfIntersectionY(int yB1, int yK1, double yX)
{
    return Convert.ToDouble(yK1 * yX + yB1);
}
double x = PointOfIntersectionX(b1, b2, k1, k2);
double y = PointOfIntersectionY(b1, k1, x);
Console.WriteLine($"-> ({x};{y})");