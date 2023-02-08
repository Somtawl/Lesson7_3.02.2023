Console.WriteLine("Введите количество столбцов в массиве");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк в массиве");
int size2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите столбец заправиваемого элемента");
int point1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите строку заправиваемого элемента");
int point2 = Convert.ToInt32(Console.ReadLine());
int[,] SomeArray = new int[size1,size2];

void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < SomeArray.GetLength(0); i++)
    {

        for (int j = 0; j < SomeArray.GetLength(1); j++)
        {
            SomeArray[i, j] = random.Next(1, 11);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],5}");
        }
    }
}

FillArray(SomeArray);
Console.WriteLine("Массив");
PrintArray(SomeArray);
Console.WriteLine();
if (point1 < size1 || point2 < size2) Console.WriteLine("Запрашиваемый элемент {0}",SomeArray[point1,point2]);
else Console.WriteLine("Танного элемента в массиве нет");