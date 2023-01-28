/* Напишите программу, которая:
1. выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
Например: [1,0,1,1,0,1,0,0] */
/* int[] array = new int[8];
int[] array1 = new int[8]{1,2,3,4,5,6,7,8};
int[] array2 = {1,2,3};
var array3 = new int[8]; //var используется только тогда, когда заранее известен тип данных в массиве. По умолчанию он int. */
void NewArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
    collection[index] = new Random().Next(0,2);
    Console.Write($"{collection[index]} ");
    index++;
}
}
int[] array = new int[8];
NewArray(array);