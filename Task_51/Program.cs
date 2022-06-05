//Программа находит сумму элементов. находящихся на главной диагонали массива

Console.Write("Введите m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n = ");
int n = int.Parse(Console.ReadLine());

int[,] arrRes = GetArray(m, n); //метод создания массива

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

PrintArray(arrRes);// печать массива

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


int sum = GetsumMainDiag(arrRes); // метод находит сумму элементов. находящихся на главной диагонали

int GetsumMainDiag(int[,] array)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) 
            {
                summ = summ + array[i,j];
            }
        }
    }
    return summ;
}

Console.WriteLine($"Сумма всех элементов, находящихся на главной диагонали массива = {sum}");