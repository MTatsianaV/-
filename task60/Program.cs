/*  1. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    2. Напишите программу, которая будет построчно выводить массив, 
    3. добавляя индексы каждого элемента.
    Например, задан массив размером 2 x 2 x 2.
    Результат:
    66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
    34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1) */
int[,,] CreateMatrix3D(int rows, int columns, int depth)
{
    int[,,] matrix3D = new int[rows, columns, depth];
    Random rnd = new Random();
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int h = 0; h < matrix3D.GetLength(2); h++)
            {
                int newNumber = rnd.Next(0, 10);
                for (int k = 0; k < matrix3D.GetLength(0); k++)
                {
                    for (int l = 0; l < matrix3D.GetLength(1); l++)
                    {
                        for (int m = 0; m < matrix3D.GetLength(2); m++)
                        {
                            if (newNumber == matrix3D[k, l, m])
                            {
                                newNumber = rnd.Next(0, 10);
                            }
                        }
                    }
                }
                matrix3D[i, j, h] = newNumber;
            }
        }
    }
    return matrix3D;
}
void PrintMatrix3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int h = 0; h < matrix.GetLength(2); h++)
            {
                Console.Write($"{matrix[i, j, h],3} ({i},{j},{h})  ");
            }
        }
        Console.WriteLine();
    }
}
int[,,] array3D = CreateMatrix3D(2, 2, 2);
if (array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2) < 99)
    PrintMatrix3D(array3D);
else Console.WriteLine("Создать матрицу с такими параметрами невозможно!");