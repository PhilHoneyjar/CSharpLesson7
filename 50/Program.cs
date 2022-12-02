// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


System.Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
System.Console.Write("Check number in array: ");
int number = Convert.ToInt32(Console.ReadLine());


GetFillArray(array);
PrintArray(array);
CheckNumberInArray(array, number);


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


void CheckNumberInArray (int[,] array, int number)
{
    int checkNumber = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
                System.Console.WriteLine($"Number {number} found in row {i + 1} column {j + 1}");
            else checkNumber++;
        }
    }
    if (checkNumber == array.Length)
        System.Console.WriteLine("Number not found");
}