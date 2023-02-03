/* Напишите программу, которая:
1. на вход принимает позиции элемента в двумерном массиве
2. возвращает значение этого элемента 
3. или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
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
string FindArrayIJ(int[,] matrix, int row, int column)
{
    string res = string.Empty;
    if (row >= matrix.GetLength(0) || column >= matrix.GetLength(1))
        res = "Такого элемента в массиве нет!";
    else res = $"{matrix[row, column]}";
    return res;
}
int[,] array2D = CreateMatrixRndInt(4, 5, -99, 99);
Console.Write("Введите номер строки искомого элемента (нумерация начинается от нуля): ");
int rowsNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца искомого элемента (нумерация начинается от нуля): ");
int columnsNumber = Convert.ToInt32(Console.ReadLine());
PrintMatrix(array2D);
string findArrayIJ = FindArrayIJ(array2D, rowsNumber, columnsNumber);
Console.WriteLine(findArrayIJ);