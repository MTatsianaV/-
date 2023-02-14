/*  1. Задайте двумерный массив из целых чисел.
    2. Напишите программу, которая удалит строку и столбец, 
    на пересечении которых расположен наименьший элемент массива.
    Например:
    1 4 7 2 
    5 9 2 3 
    8 4 2 4
    5 2 6 7
    Наименьший элемент 1.
    9 2 3
    4 2 4 
    2 6 7 */
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
int[] IndexMinNumber(int[,] matrix)
{
    int[] array = new int[2];
    array[0] = 0;
    array[1] = 0;
    int minNumber = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minNumber)
            {
                minNumber = matrix[i, j];
                array[0] = i;
                array[1] = j;
            }
        }
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
int[,] CreateMatrixWithoutMin(int[,] matrix, int[] array)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == array[0]) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == array[1]) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}
int[,] array2D = CreateMatrixRndInt(3, 3, -10, 10);
PrintMatrix(array2D);
int[] arr = IndexMinNumber(array2D);
PrintArray(arr);
int[,] matrixWithoutMin = CreateMatrixWithoutMin(array2D, arr);
PrintMatrix(matrixWithoutMin);