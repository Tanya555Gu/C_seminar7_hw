// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5    7  -2  -0,2
//   1 -3,3   8  -9,9
//   8  7,8 -7,1    9

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] Generate2DArray(int cntRows, int cntColumns, int minLimit, int maxLimit)
{
    double[,] array = new double[cntRows, cntColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.Next(minLimit, maxLimit) + rnd.NextDouble(), 2);
        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество столбцов");
int minLimit = ReadInt("Минимальное случайное значение");
int maxLimit = ReadInt("Максимальное случайное значение");
double[,] array = Generate2DArray(rows, columns, minLimit, maxLimit);
Print2DArray(array);