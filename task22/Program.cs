/* Напишите программу, которая:
1. принимает на вход число (N)
2. выдаёт таблицу квадратов чисел от 1 до N.
Например:
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

/* Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1) Console.WriteLine("Некорректный ввод! ");
for (int a = 1; a <= n; a++)
{
    Console.WriteLine($"{a} -> {a * a}");
} */


Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1) Console.WriteLine("Некорректный ввод! ");
else SquareNumbers (n);
void SquareNumbers (int number)
{
for (int a = 1; a <= number; a++)
{
    Console.WriteLine($"{a} -> {a * a}");
}
}