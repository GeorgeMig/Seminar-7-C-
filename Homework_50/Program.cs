//ПРОГРАММА, КОТОРАЯ НАХОДИТ НУЖНЫЙ ЭЛЕМЕНТ МАССИВА 

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 10);

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

Console.Write("Введите номер строки, в которой содержится искомое значение = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Ещё введите номер столбца, в котором содержится искомое значение = ");
int n = int.Parse(Console.ReadLine());

if (m <= arrRes.GetLength(0) && n <= arrRes.GetLength(1))
{
    Console.WriteLine($"Искомое значение => {arrRes[m, n]}");
}
else
{
    Console.WriteLine("Такого элемента нет в массиве");
}
