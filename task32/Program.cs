/* Напишите программу замены элементов массива: 
1. положительные элементы замените на соответствующие отрицательные
2. отрицательные элементы замените на соответствующие положительные
Например:
[-4, -8, 8, 2] -> [4, 8, -8, -2] */
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
/* void InverseArray (int[] array)
{
   Console.Write("[");
   for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i] * -1}, ");
        else Console.WriteLine($"{array[i] * -1}]");
    } 
} */
void InverseArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    } 
}
int[] arr = CreateArrayRndInt(12, -99, 99);
PrintArray(arr);
InverseArray (arr);
PrintArray(arr);