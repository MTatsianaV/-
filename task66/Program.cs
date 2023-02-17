/*  1. Задайте значения M и N. 
    2. Напишите программу, которая:
    найдёт сумму натуральных элементов в промежутке от M до N. 
    Выполнить с помощью рекурсии.
    Например:
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30 */
Console.Write("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberN > 0 && numberM > 0)
{
    int sumNaturalNumbersFromMToN = SumNaturalNumbersFromMToN(numberM, numberN);
    Console.WriteLine(sumNaturalNumbersFromMToN);
}
else Console.WriteLine("Error! ");
int SumNaturalNumbersFromMToN(int numM, int numN)
{
    if (numM == numN) return numM;
    if (numM < numN) return numM + SumNaturalNumbersFromMToN(numM + 1, numN);
    return numN + SumNaturalNumbersFromMToN(numM, numN + 1);
}