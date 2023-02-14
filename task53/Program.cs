/*  1. Задайте двумерный массив.
    2. Напишите программу, 
    которая поменяет местами первую и последнюю строки массива. */
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
void CreateMatrixReplaceOneLastRows(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int tmp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = tmp;
    }
}
int[,] array2D = CreateMatrixRndInt(4, 5, -99, 99);
PrintMatrix(array2D);
CreateMatrixReplaceOneLastRows(array2D);
Console.WriteLine();
PrintMatrix(array2D);