/* 1. Задайте массив, заполненный случайными положительными трёхзначными числами. 
2. Напишите программу, которая покажет количество чётных чисел в массиве.
Например:
[345, 897, 568, 234] -> 2 */
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
        else Console.Write($"{array[i]}]");
    }
}
int CountEvenElem(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}
int[] arr = CreateArrayRndInt(9, 100, 999);
int countEvenElem = CountEvenElem(arr);
PrintArray(arr); Console.Write($" -> {countEvenElem}");