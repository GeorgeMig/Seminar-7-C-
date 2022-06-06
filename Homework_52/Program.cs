//ПРОГРАММА, ПОЗВОЛЯЮЩАЯ ОПРЕДЕЛИТЬ СРЕДНЕЕ АРИФМИТИЧЕСКОЕ ССЕХ ЭЛЕМЕНТОВ СТОЛБЦОВ МАССИВА.

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);

        }
    }
    return array;
}

int m = 4;
int n = 4;
int[,] arrRes = GetArray(m, n); //метод создания массива 

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
Console.WriteLine();
Console.WriteLine("Среднее арифмитическое всех элементов в столбцах массива");

void FindAve(int[,] array, int d)
{
    double average = 0;
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }

        average = (sum / d);
        Console.Write(average + "; ");
        sum = 0;
    }
}

FindAve(arrRes, m);// метод считающий среднее арифмитическое всех элементов каждого столбца массива и выводящий их на экран.
