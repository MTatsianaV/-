/* Напишите программу, которая:
1. принимает на вход пятизначное число
2. проверяет, является ли оно палиндромом.
Например:
14212 -> нет
23432 -> да
12821 -> да */
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int  palindrome = Palindrome(number);
if (number < -99999 || number > 99999) Console.WriteLine("Некорректный ввод! ");
else if (number >= -99999 && number <= -10000) Console.WriteLine($"Число {number} не является палиндромом! ");
else if (number >= - 9999 && number <= 9999) Console.WriteLine("Некорректный ввод! ");
else if (palindrome == number) Console.WriteLine($"Число {number} является палиндромом! ");
else Console.WriteLine($"Число {number} не является палиндромом! ");
int Palindrome(int num)
{
int result = ((num % 10) * 10000 + ((num / 10) % 10) * 1000 + ((num / 100) % 10) * 100 + ((num / 1000) % 10) * 10 + num / 10000);
return result;
} 