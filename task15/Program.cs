/* Напишите программу, которая:
1. принимает на вход цифру, обозначающую день недели.
2. проверяет, является ли этот день выходным.
Например:
6 -> да
7 -> да
1 -> нет */
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
int day = Day(number);
if (day == 1) Console.Write("да, этот день выходной ");
if (day == 2) Console.Write("нет, этот день не выходной ");
if (day == 3) Console.Write("error, проверьте правильность введённого номера! ");
int Day(int num)
{
     if (num == 6 || num ==7) return 1;
     if (num >0 && num < 6) return 2;
     else return 3;    
}