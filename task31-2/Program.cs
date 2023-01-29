/* Задайте массив:
1. из 12 элементов 
2. заполненный случайными числами из промежутка [-9, 9]. 
3. найдите сумму отрицательных и положительных элементов массива.
Например, 
в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, 
сумма отрицательных равна -20. */
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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
int[] GetSumPositivNegativElem(int[] array)
{
    int sumNeg = default;
    int sumPos = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPos += array[i]; // sum = sum + array[i]  
        if (array[i] < 0) sumNeg += array[i];
    }
    return new int[] { sumNeg, sumPos };
}
int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] sumPositivNegativElem = GetSumPositivNegativElem(arr);
Console.WriteLine($"Сумма положительных элементов равна: {sumPositivNegativElem[1]}, сумма отрицательных элементов равна: {sumPositivNegativElem[0]}");
