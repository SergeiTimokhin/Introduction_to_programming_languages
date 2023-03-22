/* Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/
int GetValue(string value)
{
    Console.Write(value);
    return Convert.ToInt32(Console.ReadLine());
}

void GetArray(double[,] array)
{
    Random temp = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToDouble(temp.Next(-100, 100) / 10.0);
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void GetResult(double[,] array, int x, int y)
{

    if (x > array.GetLength(0) || y > array.GetLength(1))
    {
        Console.WriteLine("Элемент отсутствует");
    }
    else
    {
        Console.WriteLine($"В строке {x} и в столбце {y} присутствует элемент {array[x - 1, y - 1]}");
    }
}
int m = GetValue("Введите колличество строк: ");
int n = GetValue("Введите колличество столбцов: ");
double[,] A = new double[m, n];
GetArray(A);
Console.WriteLine("Массив чисел: ");
PrintArray(A);
int x = GetValue("Введите номер строки: ");
int y = GetValue("Введите номер столбца: ");
GetResult(A, x, y);