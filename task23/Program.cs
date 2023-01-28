/* Напишите программу, которая:
1. принимает на вход число (N)
2. выдаёт таблицу кубов чисел от 1 до N.
Например:
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1) Console.WriteLine("Некорректный ввод! ");
else SquareNumbers(n);
void SquareNumbers(int number)
{
    for (int count = 1; count <= number; count++)
    {
        Console.WriteLine($"{count} -> {count * count * count}");
    }
}
