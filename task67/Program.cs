/*  Напишите программу, которая:
    1. будет принимать на вход число 
    2. возвращать сумму его цифр.
    Например: 
    453 -> 12
    45 -> 9 */
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumOfDigits = SumOfDigits(number);
Console.Write(sumOfDigits);
int SumOfDigits(int num)
{
    if (num < 0) num = num * -1;
    if (num == 0) return 0;
    return num % 10 + SumOfDigits(num / 10) % 10;
}