/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int GetDimension(string message)
{
    Console.WriteLine(message);
    int dimension = int.Parse(Console.ReadLine());
    return dimension;
}
int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = rnd.Next(1, 10);
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
void GetAverageOfColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {   double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double average = sum / array.GetLength(0);
        Console.Write($"{Math.Round(average, 1)}, ");
    }
}

int m = GetDimension("Введите число строк массива: ");
int n = GetDimension("Введите число столбцов массива: ");
int[,] arr = FillArray(m, n);
PrintArray(arr);
Console.WriteLine("Среднее арифметическое столбцов массива: ");
GetAverageOfColumns(arr);