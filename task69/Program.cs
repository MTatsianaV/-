/* Напишите программу, которая:
    1. на вход принимает два числа А и В 
    2. возводит число А в степень В с помощью рекурсии.
    Например: 
    А = 3, В = 5 -> 243
    А = 2, В = 3 -> 8  */
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB > 0)
{
    int degreeOfNumbers = DegreeOfNumber(numberA, numberB);
    Console.Write(degreeOfNumbers);
}
else Console.WriteLine("Вы ввели не натуральную степень!");
int DegreeOfNumber(int num, int degree)
{
    if (degree < 1) return 1;
    return num * DegreeOfNumber(num, degree - 1);
}