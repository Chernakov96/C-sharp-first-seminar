// Задача 49: 
// 1. Задайте двумерный массив. 
// 2. Найдите элементы, укоторых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < rows/*i < matrix.GetLength(0)*/; i++) //0 rows
    {
        for (int j = 0; j < columns/*i < matrix.GetLength(1)*/; j++) //1 columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[,] DoubleEvenIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) //0 rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //1 columns
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
        }
    }

    return matrix;
}

int[,] array2d = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
int[,] result = DoubleEvenIndex(array2d);
PrintMatrix(result);