/* Напишите программу, которая:
1. принимает на вход число
2. выдаёт количество цифр в числе
Например:
456 -> 3
78 -> 2
89126 -> 5 */
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberOfDigits = NumberOfDigits(number);
Console.WriteLine($"Во введённом числе количество цифр: {numberOfDigits} ");
int NumberOfDigits(int num)
{
    int count = 1;
    if (num < 0) num = num * -1;
    while (num > 10)
    {
        num = num / 10;
        count = count + 1;
    }
    return count;
}
