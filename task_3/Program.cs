// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Generate2DArray(int cntRows, int cntColumns, int minLimit, int maxLimit)
{
    int[,] array = new int[cntRows, cntColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minLimit, maxLimit);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
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

double[] FindAverage(int[,] array)
{
    double[] arAver = new double[array.GetLength(1)];
    int k = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        arAver[k] = sum / array.GetLength(0);
        k++;
    }
    return arAver;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f2}\t");
    }
}

int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество столбцов");
int minLimit = ReadInt("Минимальное случайное значение");
int maxLimit = ReadInt("Максимальное случайное значение");
int[,] array = Generate2DArray(rows, columns, minLimit, maxLimit);
Print2DArray(array);
System.Console.WriteLine("Среднее арифметическое каждого столбца");
double[] arAver = FindAverage(array);
PrintArray(arAver);