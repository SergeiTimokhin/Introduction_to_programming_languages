/*  
Задайте двумерный массив. Напишите программу,которая 
упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
            array[i, j] = new Random().Next(0, 10);
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

void GetOrder(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = 0; x < array.GetLength(1) - 1; x++)
            {
                if (array[i, x] < array[i, x + 1])
                {
                    double temp = array[i, x + 1];
                    array[i, x + 1] = array[i, x];
                    array[i, x] = temp;
                }

            }

        }

    }
}
int m = GetValue("Введите колличество строк: ");
int n = GetValue("Введите колличество столбцов: ");
double[,] A = new double[m, n];

GetArray(A);
Console.WriteLine("Исходный массив:");
PrintArray(A);
GetOrder(A);
Console.WriteLine("Упорядочный массив:");
PrintArray(A);