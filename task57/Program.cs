/*  1. Составить частотный словарь элементов двумерного массива. 
    2. Частотный словарь содержит информацию о том, 
    сколько раз встречается элемент входных данных.
    Например:
{1, 9, 9, 0, 2, 8, 0, 9} ->
0 встречается 2 раза.
1 встречается 1 раз.
2 встречается 1 раз.
8 встречается 1 раз.
9 встречается 3 раза. */
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}
int[] singleArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count++] = matrix[i, j];
        }
    }
    Array.Sort(array);
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
void GetCountSameNumbers(int[] array)
{
    int temp = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == temp) count++;
        else
        {
            Console.WriteLine($"{temp} встречается {count} раз.");
            temp = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{temp} встречается {count} раз.");
}
int[,] array2D = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] arr = singleArray(array2D);
PrintArray(arr);
GetCountSameNumbers(arr);