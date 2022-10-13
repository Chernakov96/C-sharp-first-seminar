// Задача 59: 
// 1. Задайте двумерный массив из целых чисел.
// Напишите программу, которая 
// 2. удалит строку и столбец, напересечении которых расположен наименьший элемент массива.

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

int[,] DeleteMinRowsColumn(int[,] matrix, int[] minIndex)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int i1 = 0;
    int j1 = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {

        if (i1 == minIndex[0]) i1++;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (j1 == minIndex[1]) j1++;
            result[i, j] = matrix[i1, j1];
            j1++;
        }
        i1++;
        j1 = 0;
    }
    return result;
}


int[,] array2d = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(array2d);
int array2dMin = FindMatrixMin(array2d);
