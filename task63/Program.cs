﻿/*  1. Задайте значение N. 
    2. Напишите программу, которая:
    выведет все натуральные числа в промежутке от 1 до N.
    Например:
    N = 5 -> 1, 2, 3, 4, 5
    N = 6 -> 1, 2, 3, 4, 5, 6 */
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
void NaturalNumbers(int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}
NaturalNumbers(number);