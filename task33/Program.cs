/* 1. Задайте массив. 
2. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
Например:
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}
/* int FindNumber( int[] array, int num)
{
     int position = -1;
for (int i = 0; i < array.Length; i++)
{
   if (array[i] == num)
   {
    position = i;
    break;
   }
}
return position;
} */
bool FindNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return false;
}
Console.WriteLine("Введите длинну массива и число, которое требуется найти: ");
int size = Convert.ToInt32(Console.ReadLine());
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(size, 0, 10);
PrintArray(arr);
Console.WriteLine(FindNumber(arr, number) ? "да" : "нет");
/* int pos = FindNumber(arr, number);
if (pos == -1) Console.WriteLine ("нет");
else Console.WriteLine ("да"); */