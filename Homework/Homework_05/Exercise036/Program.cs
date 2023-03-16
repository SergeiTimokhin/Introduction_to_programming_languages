/*  Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


/* РЕШЕНИЕ ЧЕРЕЗ МАССИВ*/

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
        array[i] = new Random().Next(min, max);
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

int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int length = GetLength("Введите длину массива: ");
int min = GetMinMax("Введите наименьший элемент массива: ");
int max = GetMinMax("Введите наибольший элемент массива: ");
int[] array = GetArray(length, min, max);
Console.WriteLine();
Print(array);
int sum = GetSum(array);
Console.WriteLine();
Console.WriteLine("Сумма элементов на нечётных позициях: " + GetSum(array));