/* Напишите программу, которая:
1. принимает на вход три числа
2. выдаёт максимальное из этих чисел.
Например:
2, 3, 7 -> 7
44, 5, 78 -> 78
22, 3, 9 -> 22 */
Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > number1)
{
    max = number2;
    if (number3 > number2)
    {
        max = number3;
    }
}
else if (number3 > number1)
{
    max = number3;
}
Console.WriteLine($"Максимальное число:{max} ");