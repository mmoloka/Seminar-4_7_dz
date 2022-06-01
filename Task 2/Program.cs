/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/
int GetDimension(string message)
{
    Console.WriteLine(message);
    int dimension = int.Parse(Console.ReadLine());
    return dimension;
}
int [,] FillArray(int rows, int columns)
{
    int [,] array = new int [rows, columns];
    Random rnd = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            array[i, j] = rnd.Next(1, 10);
    }
    return array;
}
void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}  ");
            Console.WriteLine();
    }
}
void GetPositionOfElement(int [,] array)
{
    Console.WriteLine("Введтите позицию строки искомого элемента массива: ");
    int i = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите позицию столбца искомого элемента: ");
    int j = int.Parse(Console.ReadLine());
    if(i <= array.GetLength(0) && j <= array.GetLength(1)) Console.WriteLine($"Искомый элемент равен {array[i, j]}.");
    else Console.WriteLine("Такого числа в массиве нет.");
}
int m = GetDimension("Введите число строк массива: ");
int n = GetDimension("Введите число столбцов массива: ");
int [,] arr = FillArray(m, n);
PrintArray(arr);
GetPositionOfElement(arr);
