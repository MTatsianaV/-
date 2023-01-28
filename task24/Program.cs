﻿/* Напишите программу, которая:
1. принимает на вход число (А)
2. выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */
Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(number);
if (number < 1) Console.WriteLine("Некорректный ввод! ");
else Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");
int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}