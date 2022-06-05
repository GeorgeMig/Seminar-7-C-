//ПРОГРАММА, КОТОРАЯ НАХОДИТ ЭЛЕМЕНТЫ МАССИВА, У КОТОРЫХ ОБА ИНДЕКСА ЧЕТНЫЕ И ВОЗВОДИТ ЭТИ ЭЛЕМЕНТЫ В КВАДРАТ

Console.Write("Введите m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n = ");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 6);

        }
    }
    return array;
}

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

for (int i = 1; i < arrRes.GetLength(0); i++)
{
    for (int j = 1; j < arrRes.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            arrRes[i, j] = arrRes[i, j] * arrRes[i, j];
        }

    }
}

Console.WriteLine();

PrintArray(arrRes);