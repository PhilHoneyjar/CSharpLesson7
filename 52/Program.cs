// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

System.Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

GetFillArray(array);
PrintArray(array);
CountColumnAverage(array);

void GetFillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = System.Convert.ToInt32(new Random().Next(0, 51));
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.Write("\n");
    }
}

void CountColumnAverage(int[,] array)
{
    System.Console.Write("Arithmetical means of columns: ");
    int[,] revertArr = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < revertArr.GetLength(0); i++)
    {
        for (int j = 0; j < revertArr.GetLength(1); j++)
        {
            revertArr[i, j] = array[j, i];
        }
    }
    double[] counter = new double[revertArr.GetLength(0)];
    for (int i = 0; i < revertArr.GetLength(0); i++)
    {
        for (int j = 0; j < revertArr.GetLength(1); j++)
        {
            counter[i] += revertArr[i, j];
        }
        System.Console.Write($"{Math.Round(counter[i] / revertArr.GetLength(1), 2)} ");
    }
}