/* Напишите программу, которая:
1. будет преобразовывать десятичное число в двоичное.
Например, 
45 -> 101101
3 -> 11
2 -> 10 */
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


// Строковый способ.
/* string InverseNumbers(int num)
{
    string res = string.Empty;
    while (num > 0)
    {
        res = num % 2 + res;
        num /= 2;
    }
    return res;
}
string result = InverseNumbers(number);
Console.Write(($"{number} -> {inverseNumbers}")); */

// Строковый способ.
int InverseNumbers(int num)
{
    int res = 0;
    int count = 1;
    while (num > 0)
    {
        res = res + num % 2 * count;
        num /= 2;
        count = count * 10;
    }
    return res;
}
int inverseNumbers = InverseNumbers(number);
Console.WriteLine($"{number} -> {inverseNumbers}");