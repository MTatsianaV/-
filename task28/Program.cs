/* Напишите программу, которая:
1. принимает на вход число N
2. выдаёт произведение чисел от 1 до N.
Например:
4 -> 24
5 -> 120 */
Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Некорректный ввод! ");
else 
{
    int productNumbers = ProductNumbers(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {productNumbers}");
}
int ProductNumbers(int num)
{
    int product = 1;
    for (int i = 1; i <= num; i++)
    {
        product = product * i;
    }
    return product;
}
