/*  1. Задайте двумерный массив.
    2. Напишите программу, которая заменяет строки на столбцы.
    3. В случае, если это невозможно, программа должна вывести сообщение. */
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
int[,] CreateMatrixReplaceRowsColumns(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}
int[,] array2D = CreateMatrixRndInt(3, 3, -99, 99);
PrintMatrix(array2D);
Console.WriteLine();
if (array2D.GetLength(0) == array2D.GetLength(1))
{
    int[,] newArray2D = CreateMatrixReplaceRowsColumns(array2D);
    PrintMatrix(newArray2D);
}
else Console.WriteLine("Невозможно перевернуть данный массив!");