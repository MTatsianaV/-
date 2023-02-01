/* Напишите программу, которая:
1. принимает на вход три числа;
2. проверяет, может ли существовать треугольник со сторонами такой длины.
PS! Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон. */
Console.WriteLine("Введите три числа: ");
int sidesLength1 = Convert.ToInt32(Console.ReadLine());
int sidesLength2 = Convert.ToInt32(Console.ReadLine());
int sidesLength3 = Convert.ToInt32(Console.ReadLine());
bool IsItTriangle(int A, int B, int C)
{
    if (A + B > C && A + C > B && B + C > A) return true;
    else return false;
}
Console.WriteLine(IsItTriangle(sidesLength1, sidesLength2, sidesLength3) ? "треугольник с такими сторонами может существовать" : "треугольник с такими сторонами не может существовать");
