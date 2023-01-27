/* Напишите программу, которая:
1. по заданному номеру четверти, 
2. показывает диапазон возможных координат точек в этой четверти (x и y) */
Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
string result = Quater(num);
Console.WriteLine(result);

/* string Quater(int number)
{
if (number == 1) return "x > 0 и y > 0";
if (number == 2) return "x < 0 и y > 0";
if (number == 3) return "x < 0 и y < 0";
if (number == 4) return "x > 0 и y < 0";
return "введен некорректный номер четверти";
} */

string Quater(int number)
{
    switch (number)
    {
case 1: return "x > 0 и y > 0";
case 2: return "x < 0 и y > 0";
case 3: return "x < 0 и y < 0";
case 4: return "x > 0 и y < 0";
default: return "введен некорректный номер четверти";
    }
}
