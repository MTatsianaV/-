/* Напишите программу, которая:
1. выводит случайное число из отрезка [10, 99]
2. показывает наибольшую цифру числа.
Например:
78 -> 8
12-> 2
85 -> 8 */
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10..99]: {number}");
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа: {MaxDigit(number)}");
int MaxDigit(int num)
{
int firstDigit = num / 10;
int secondDigit = num % 10;
if (firstDigit > secondDigit) return (firstDigit);
else return (secondDigit);
}


