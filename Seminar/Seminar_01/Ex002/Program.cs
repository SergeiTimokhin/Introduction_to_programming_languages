Console.Write("Число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int index;
index = (int)(-N);
while (index <= N)
{
    if (index % 2 == 0)
        Console.Write(index + " ");

    index++;
}