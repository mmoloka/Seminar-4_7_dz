/*
 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5     7    -2  -0,2
  1  -3,3     8  -9,9
  8   7,8  -7,1     9
*/
int GetDimension(string message)
{
    Console.WriteLine(message);
    int dimension = int.Parse(Console.ReadLine());
    return dimension;
}
double [,] FillArray(int rows, int columns)
{
    double [,] array = new double[rows, columns];
    Random rnd = new Random();

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            array[i,j] = rnd.Next(-9, 11) - Math.Round(rnd.NextDouble(),1);
    } 
    return array;
}
void PrintArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}     ");
            Console.WriteLine();
    }
}    

int m = GetDimension("Введите число строк массива: ");
int n = GetDimension("Введите число столбцов массива: ");
double [,] arr = FillArray(m, n);
PrintArray(arr);