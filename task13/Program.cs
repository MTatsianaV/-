/* Напишите программу, которая:
1. выводит третью цифру заданного числа 
или 
2. сообщает, что третьей цифры нет.
Например:
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
int ThirdDigit(int num)
{
  while (num > 999) num = num / 10;
  int num1 = num % 10;
  return num1;  
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * -1;
int result = ThirdDigit(number);
if (number < 100) Console.WriteLine("Третьей цифры в данном числе нет! ");
else Console.WriteLine($"Третья цифра: {result} ");
