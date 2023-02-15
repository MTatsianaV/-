/*  1. Задайте прямоугольный двумерный массив. 
    2. Напишите программу, которая будет находить 
    строку с наименьшей суммой элементов.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке 
    и выдаёт номер строки с наименьшей суммой элементов: 
    1 строка */
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
int[] ArraySumOfRow(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}
void MinArraySumOfRow(int[] array)
{
    int min = array[0];
    int minRow = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minRow = i + 1;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке {minRow}");
}
int[,] array2D = CreateMatrixRndInt(4, 5, 0, 10);
PrintMatrix(array2D);
int[] arraySumOfRow = ArraySumOfRow(array2D);
MinArraySumOfRow(arraySumOfRow);