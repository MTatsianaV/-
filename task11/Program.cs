/* Напишите программу, которая:
1. выводит случайное трёхзначное число
2. удаляет вторую цифру этого числа.
Например:
456 -> 46
782 -> 72
918 -> 98 */
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка [100..999]: {number}");
int newNumber = NewNumber(number);
Console.WriteLine($"Новое число: {newNumber}");
int NewNumber(int num)
{
    int num1 = num / 100;
    int num2 = num % 10;
    int num3 = num1 * 10 + num2;
    return num3;
}