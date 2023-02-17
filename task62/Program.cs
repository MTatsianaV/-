/*  Напишите программу, которая:
    1. заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07 */
int[,] CreateMatrixSpiralInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    int elem = 00;
    int count = 00;
   if (count <= matrix.GetLength(0) / 2)
   {
    for (int j = count; j < matrix.GetLength(0)-count; j++)
    {
        int i = count;
        for (i = count+1; i < matrix.GetLength(0)-count; i++)
j = matrix.GetLength(0)-count-1;
        {
            for (j = matrix.GetLength(0)-count-1; j >= count; j--)
i = matrix.GetLength(0) - count - 1;
            {
              for (i = matrix.GetLength(0) - count-2; i > count+1; i++)
              {
                matrix[i, j] = elem + 1;
              }  
            }
        }
        count++;
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
int[,] array2D = CreateMatrixSpiralInt(4, 4);
PrintMatrix(array2D);