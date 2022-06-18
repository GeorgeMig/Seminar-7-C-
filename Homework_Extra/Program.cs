int[,] GetArray(int a, int b)
{
    int m = 1;
    int[,] array = new int[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = j + m;

        }
    }
    return array;
}

int[,] arrRes = GetArray(5, 5); //метод создания массива 

void RevArr(int[,] array)
{
    int t = 0;
    for (int i = 0; i < array.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < array.GetLength(1) / 2; j++)
        {
            t = array[i, j];
            array[i, j] = array[i, array.GetLength(1) - j - 1];
            array[i, array.GetLength(1) - j - 1] = t;

        }
        Console.WriteLine();
    }

}

RevArr(arrRes); // разворот некоторых строчек массива наоборот, чтобы строчки стали на уменьшение. Для демонстрации основного метода

void PrintArray(int[,] array)
{
    Console.WriteLine("Массив: ");
    Console.WriteLine();
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


void DetermineSequenceArr(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[i, j + 1] && array[i, arrRes.GetLength(1) - 2] < array[i, arrRes.GetLength(1) - 1])
            {
                Console.WriteLine($"Последовательность в строке {i + 1} является возрастающей");
                break;
            }
            else if (array[i, j] > array[i, j + 1] && array[i, array.GetLength(1) - 2] > array[i, array.GetLength(1) - 1])
            {
                Console.WriteLine($"Последовательность в строке {i + 1} является убывающей");
                break;
            }

        }

    }
    Console.WriteLine();
}

DetermineSequenceArr (arrRes);