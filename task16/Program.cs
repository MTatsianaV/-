/* Напишите программу, которая:
1. принимает на вход два числа
2. проверяет, является ли одно число квадратом другого.
Например:
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */
Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
bool result = Square (number1, number2);
if (result) Console.WriteLine("да");
else Console.WriteLine("нет");
bool Square (int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}
