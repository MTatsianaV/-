/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
Например:
0,7,8,-2,-2 -> 2
-1.-7.567.89.223 -> 3 */
Console.WriteLine("Напишите, сколько чисел Вы хотели бы ввести: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа: ");
int[] CreateOwnArray(int s)
{
    int[] array = new int[s];
    for (int i = 0; i < s; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}
int NumberOfPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count = count + 1;
    }
    return count;
}
int[] arr = CreateOwnArray(size);
int numberOfPositive = NumberOfPositive(arr);
PrintArray(arr); Console.WriteLine($" -> {numberOfPositive}");
