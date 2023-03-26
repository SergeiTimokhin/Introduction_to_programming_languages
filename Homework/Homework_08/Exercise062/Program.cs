/*  
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int GetValue(string value)
{
    Console.Write(value);
    return Convert.ToInt32(Console.ReadLine());
}

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }
}

void PrintArray(int[,] array)
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

void GetResult(int[,] array, int n)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avarage = avarage + array[i, j];
        }
        avarage = Math.Round(avarage / n, 1);
        Console.Write(avarage + ";");
    }
}


int m = GetValue("Введите колличество строк: ");
int n = GetValue("Введите колличество столбцов: ");
int[,] A = new int[m, n];
GetArray(A);
PrintArray(A);
Console.Write("Среднее значение чисел в каждом столбце: ");
GetResult(A, n);



