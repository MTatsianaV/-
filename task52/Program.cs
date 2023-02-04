/*  1. Задайте двумерный массив из целых чисел. 
    2. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}
double[] ArithmeticMeanColumns(int[,] matrix)
{
    int size = matrix.GetLength(1);
    double[] array = new double[size];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        array[j] = Math.Round(sum / matrix.GetLength(1), 2);
    }
    return array;
}
void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],5} , ");
        else Console.Write($"{array[i],5} ] ");
    }
}
int[,] array2D = CreateMatrixRndInt(3, 3, -10, 10);
double[] rithmeticMeanColumns = ArithmeticMeanColumns(array2D);
PrintMatrix(array2D);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintArrayDouble(rithmeticMeanColumns);