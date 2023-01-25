/* Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8 */
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 999)
{
 Console.WriteLine("Вы ввели не трёхзначное число! ");   
}
else if (number < 100)
{
 Console.WriteLine("Вы ввели не трёхзначное число! ");   
}
else if (number == 0)
{
 Console.WriteLine("Error ");
 }
 if (0 < number) 
{
int number1 = number % 10;
Console.WriteLine($"Последняя цифра введённого числа: {number1} ");
}
else if (number < 0)
{
 int number1 = -number % 10;
Console.WriteLine($"Последняя цифра введённого числа: {number1} ");   
}