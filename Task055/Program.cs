// Задача 55: 
// 1. Задайте двумерный массив. Напишите программу, которая 
// 2. заменяет строки на столбцы. 
// 3. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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