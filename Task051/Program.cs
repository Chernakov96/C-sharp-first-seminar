// Задача 51: 
// 1. Задайте двумерный массив. 
// 2. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, ");
            else Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine("]");
    }
}

int GetSumMatrixDiagonal(int[,] matrix)
{
    int sum = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == j) sum += matrix[i,j];
        }
    }
    return sum;
}

int[,] array2d = CreateMatrixRndInt(4,4,1,9);
PrintMatrix(array2d);
int result = GetSumMatrixDiagonal(array2d);
Console.WriteLine(result);