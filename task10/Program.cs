/* Напишите программу, которая:
1. принимает на вход трёхзначное число
2. на выходе показывает вторую цифру этого числа.
Например:
456-> 5
782-> 8
918-> 1 */
int Result(int num)
{
    int num1 = (num - (num / 100) * 100) / 10;
    return num1;
}
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * -1;
if (number > 99 && number < 1000)
{
int result = Result(number);
Console.WriteLine($"Вторая цифра числа: {result}");
}
else Console.WriteLine("Вы ввели не трёхзначное число! ");
