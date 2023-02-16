/*  1. Задайте две матрицы. 
    2. Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18 */
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
int[,] GetMatrixProductOfMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}
int[,] array2D1 = CreateMatrixRndInt(3, 5, 0, 5);
int[,] array2D2 = CreateMatrixRndInt(5, 2, 0, 5);
PrintMatrix(array2D1);
Console.WriteLine();
PrintMatrix(array2D2);
Console.WriteLine();
if (array2D1.GetLength(1) == array2D2.GetLength(0))
{
    int[,] matrixProductOfMatrix = GetMatrixProductOfMatrix(array2D1, array2D2);
    PrintMatrix(matrixProductOfMatrix);
}
else Console.WriteLine("Эти матрицы перемножить невозможно!");