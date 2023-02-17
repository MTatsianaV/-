/*  1. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    2. Даны два неотрицательных числа m и n.
    Например:
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29 */
Console.Write("Введите первое неотрицательное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
if (numberN >= 0 && numberM >= 0)
{
    int resAckermanFunction = AckermanFunction(numberN, numberM);
    Console.WriteLine(resAckermanFunction);
}
else Console.WriteLine("Error! ");
int AckermanFunction(int numN, int numM)
{
    if (numN == 0) return numM + 1;
    if (numM == 0) return AckermanFunction(numN - 1, 1);
    return AckermanFunction(numN - 1, AckermanFunction(numN, numM - 1));
}