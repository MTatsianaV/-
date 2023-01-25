/* Напишите программу, которая:
1. будет принимать на вход два числа
2. выводить, является ли первое число кратным второму
3. если число 1 не кратно числу 2, то программа выводит остаток от деления.
Например:
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */
Console.Write("Введите целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = Result(number1, number2);
int Result(int num1, int num2)
{
    return (num1 % num2);
}
if (result == 0) Console.WriteLine("кратно");
else Console.WriteLine($"не кратно, остаток:{result}"); 