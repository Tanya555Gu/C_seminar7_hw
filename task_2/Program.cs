// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 1 -> 1

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

int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество столбцов");
int minLimit = ReadInt("Минимальное случайное значение");
int maxLimit = ReadInt("Максимальное случайное значение");
int[,] array = Generate2DArray(rows, columns, minLimit, maxLimit);
Print2DArray(array);
int i = ReadInt("Введите номер строки, искомого элемента");
int j = ReadInt("Введите номер столбца, искомого элемента");
if (i <= array.GetLength(0) && j <= array.GetLength(1))
{
    System.Console.WriteLine($"Элемент на данной позиции равен {array[i - 1, j - 1]}");
}
else
{
    System.Console.WriteLine("Элемента с такой позицией нет в массиве");
}
