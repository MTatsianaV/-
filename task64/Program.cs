/*  1. Задайте значение N. 
    2. Напишите программу, которая:
    выведет все натуральные числа в промежутке от N до 1. 
    Выполнить с помощью рекурсии.
Например:
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
void NaturalNumbersFromNTo1(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbersFromNTo1(num - 1);
}
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0) NaturalNumbersFromNTo1(number);
else Console.WriteLine("Вы ввели не натуральное число: ");