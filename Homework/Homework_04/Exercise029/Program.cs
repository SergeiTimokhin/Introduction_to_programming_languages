/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран */

int GetNum(string A)
{
    Console.Write(A);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length.Length; i++)
    {
        length[i] = new Random().Next(min, max);
    }
    return array;
}
//Дальше не понял как
