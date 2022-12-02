// Задайте двумерный массив размером m × n, заполненный случайными вещественными числами


System.Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];


GetFillArray(array);
PrintArray(array);


void GetFillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(0, 100) / 10.0);
        }
    }
}


void PrintArray(double[,] array)
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