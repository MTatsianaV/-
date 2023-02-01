/* Не используя рекурсию, введите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Например:
если N = 5 -> 01123
если N = 3 -> 011
если N = 7 -> 0112358 */
Console.WriteLine("Введите число: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] CreateArrayFibonacci(int s)
{
    int[] array = new int[s];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
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
int[] arr = CreateArrayFibonacci(size);
Console.Write($"{size} -> "); PrintArray(arr);