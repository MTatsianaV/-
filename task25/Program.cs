/* Напишите цикл, который:
1. принимает на вход два числа (A и B)
2. возводит число A в натуральную степень B.
Например:
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());
if (degree < 1) Console.WriteLine("Некорректный ввод! ");
else
{
    int numbersDegree = NumbersDegree(number, degree);
    Console.WriteLine($"Число {number} в степени {degree} равно {numbersDegree} ");
}
int NumbersDegree(int num, int deg)
{
    int product = num;
    for (int i = 1; i < deg; i++)
    {
        product = product * num;
    }
    return product;
}