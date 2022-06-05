//ПРОГРАММА, КОТОРАЯ ПОЗВОЛЯЕТ НАХОДИТЬ ЭЛЕМЕНТЫ ДВУМЕРНОГО МАССИВА ПО ФОРМУЛЕ m+n

Console.Write("Введите m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n = ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int [m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;

    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");

        }
        Console.WriteLine();
    }   
}
PrintArray(array);