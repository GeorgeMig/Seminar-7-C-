//ПРОГРАММА, ПОЗВОЛЯЮЩАЯ СОЗДАТЬ ДВУМЕРНЫЙ МАССИВ, ЗАПОЛНЕННЫЙ СЛУЧАЙНЫМИ ВЕЩЕСТВЕННЫМИ ЧИСЛАМИ.

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(- 100, 100);

        }
    }
    return array;
}

int[,] arrRes = GetArray(3, 4); //метод создания массива 

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();
    }
}
PrintArray(arrRes);// печать массива