/* Напишите программу, которая:
1. задаёт массив из 8 элементов 
2. заполненный псевдослучайными числами
3. выводит их на экран.
Например:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
Random rnd = new Random();
int[] GenerateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i =0; i < arr.Length; i++)  
    {
      arr[i] = rnd.Next(min, max + 1);  
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
      Console.Write($"{arr[i]}");
      if (i < arr.Length - 1) Console.Write($", ");
    }
}
int[] array = GenerateArray(8, -99, 99);
PrintArray(array); Console.Write(" -> ["); PrintArray(array); Console.Write("]");
