/* Напишите программу, которая
1. на вход принимает два числа
2. выдаёт, какое число большее
3. какое число меньшее
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < number2)
{
    Console.WriteLine($"Максимальное число:{number2} ");
    Console.WriteLine($"Минимальное число:{number1} ");
}
if (number1 > number2)
{
    Console.WriteLine($"Максимальное число:{number1} ");
    Console.WriteLine($"Минимальное число:{number2} ");
}
if (number1 == number2)
{
    Console.WriteLine("Введённые числа равны! ");
}