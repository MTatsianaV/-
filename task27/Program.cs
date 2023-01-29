/* Напишите программу, которая:
1. принимает на вход число
2. выдаёт сумму цифр в числе.
Например:
452 -> 11
82 -> 10
9012 -> 12 */
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digitsSum = DigitsSum (number);
Console.WriteLine($"Сумма цифр в числе {number} равна {digitsSum} ");
int DigitsSum (int num)
{
if (num < 0) num = num * -1;
int sum = 0;
int dig = 0;
while (num > 0)
{
   dig = num % 10;
   sum = sum + dig;
   num = num / 10; 
}
return sum;
}
