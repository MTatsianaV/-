/* 1. Задайте одномерный массив из 123 случайных чисел.
2. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов (в своём решении сделайте для 123):
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */
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
int FindNumber(int[] array, int minNum, int maxNum)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= minNum && array[i] <= maxNum)
        {
            count ++;
        }
    }
    return count;
}
int[] arr = CreateArrayRndInt(123, -200, +200);
PrintArray(arr);
int numberOfDigits = FindNumber(arr, 1, 5);
Console.WriteLine($"Количество чисел [10, 99] в массиве: {numberOfDigits}");