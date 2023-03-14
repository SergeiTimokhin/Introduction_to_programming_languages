/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран */

int GetValue(string A)
{
    Console.Write(A);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetArray(int length, int min, int max)
{
    int[] array = new int[length];
    Console.WriteLine("Сформированный массив:");
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
        Console.Write(Convert.ToInt32(array[i].ToString()));

    }

    return array;
}

void Print(int[] array)
{
    Console.WriteLine("Массив с оформлением:");
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int length = GetValue("Введите длину массива: ");
int min = GetValue("Введите наименьший элемент массива: ");
int max = GetValue("Введите наибольший элемент массива: ");
int[] res = GetArray(length, min, max);
Console.WriteLine();
Print(res);

