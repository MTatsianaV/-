/* Напишите программу, которая:
1. принимает на вход число
2. проверяет, кратно ли оно одновременно 7 и 23.
Например:
14 -> нет
46 -> нет
161 -> да */
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int remainder = Remainder(number);
if (remainder == 0) Console.WriteLine("да");
else Console.WriteLine("нет");
int Remainder (int num)
{
    int rem1 = num % 7;
    int rem2 = num % 23;
    int rem = rem1 + rem2;
    return rem;
}