/*  
Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
        {
            array[i, j] = new Random().Next(0, 10);
        }
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

int[,] GetResult(int[,] a, int[,] b, int m)
{
    int[,] c = new int[m, m];

    int temp = 0;

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(1); k++)
            {
                temp = temp + a[i, k] * b[j, k];
            }
            c[i, j] = temp;
            temp = 0;
        }
    }
    return c;
}

int m = GetValue("Введите размер матриц: ");

int[,] arrayA = new int[m, m];
int[,] arrayB = new int[m, m];
GetArray(arrayA);
GetArray(arrayB);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
int[,] multiArray = GetResult(arrayA, arrayB, m);
PrintArray(multiArray);
