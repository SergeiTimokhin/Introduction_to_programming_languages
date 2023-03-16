/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.

[3 7 22 2 78] -> 76 */

int GetLength(string Value)
{
    Console.Write(Value);
    return Convert.ToInt32(Console.ReadLine());
}

int GetMinMax(string Value)
{
    Console.Write(Value);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void Print(int[] array)
{
    Console.WriteLine("Массив:");
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int GetMinValue(int[] array)
{
    int minChar = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (minChar > array[i])
        {
            minChar = array[i];
        }
    }
    return minChar;
}
int GetMaxValue(int[] array)
{
    int maxChar = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maxChar < array[i])
        {
            maxChar = array[i];
        }
    }
    return maxChar;
}


/* int GetDiff(int MaxValue, int MinValue)
{
    int diff = MaxValue - MinValue;
    return diff;
} */

int length = GetLength("Введите длину массива: ");
int min = GetMinMax("Введите наименьший элемент массива: ");
int max = GetMinMax("Введите наибольший элемент массива: ");

int[] array = GetArray(length, min, max);
Console.WriteLine();
int MinValue = GetMinValue(array);
int MaxValue = GetMaxValue(array);
Print(array);
Console.WriteLine();
/* int A = GetDiff(MaxValue, MinValue);
Console.WriteLine(A); */
Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + $"{MaxValue - MinValue}");

