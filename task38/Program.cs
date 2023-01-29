/* 1. Задайте массив вещественных чисел.
2. Найдите разницу между максимальным и минимальным элементами массива.
Например:
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */
double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
    }
    return array;
}
void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},  ");
        else Console.Write($"{array[i]}]");
    }
}
double DifferenceMaxMin(double[] array)
{
   double max = array[0];
   double min = array[0];
   for (int i = 1; i < array.Length; i++)
   {
    if (array[i] > max) max = array[i];
   }
   for (int i = 1; i < array.Length; i++)
   {
    if (array[i] < min) min = array[i];
   }
   double diff = Math.Round((max - min), 1);
   return diff;
}
double[] arr = CreateArrayRndDouble(5, -99, 99);
double differenceMaxMin = DifferenceMaxMin(arr);
PrintArrayDouble(arr);
Console.WriteLine($" -> {differenceMaxMin}");