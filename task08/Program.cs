/* Напишите программу, которая:
1. на вход принимает число (N)
2. на выходе показывает все чётные числа от 1 до N.
Например:
5 -> 2, 4
8 -> 2, 4, 6, 8 */
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (number > 0)
{
    while (count <= number)
    {
        if (count % 2 == 0)
        {
          Console.Write($"{count}");
          if (count < number - 1)
          {
           Console.Write(", "); 
          }
        }
        count++;
    }
}
else
{
 Console.WriteLine("Введите натуральное число! ");   
}
