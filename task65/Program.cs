/*  1. Задайте значения M и N. 
    2. Напишите программу, которая:
    выведет все натуральные числа в промежутке от M до N.
    Например:
    M = 1, N = 5 -> 1, 2, 3, 4, 5
    M = 4, N = 8 -> 4, 5, 6, 7, 8 */
Console.Write("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(number1, number2);
void NaturalNumbers(int num1, int num2)
{
    Console.Write($"{num1} ");
    if (num2 == num1) return;
    if (num1 < num2) NaturalNumbers(num1 + 1, num2);
    else NaturalNumbers(num1 - 1, num2);
}