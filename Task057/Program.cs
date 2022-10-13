// Задача 57: 
// 1. Составить частотный словарь элементов
// двумерного массива. 
// 2. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] GetArrayFromMatrix(int[,] matrix)
{
    int[] result = new int[matrix.Length];

    int index = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[index] = matrix[i, j];
            index++;
        }
    }

    return result;
}

void CountPrintArrayGlossary(int[] array)
{
    int num = array[0];
    int counter = 1;

    for (int i = 1; i < array.Length; i++)
    {
        if (num == array[i])
        {
            counter++;
        }
        else
        {
            Console.WriteLine($"{num} повторяется {counter} раз");
            num = array[i];
            counter = 1;
        }
    }
    Console.WriteLine($"{num} повторяется {counter} раз");
}

int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);

int[] arrayFromMatrix = GetArrayFromMatrix(array2d);
Array.Sort(arrayFromMatrix);
PrintArray(arrayFromMatrix);

CountPrintArrayGlossary(arrayFromMatrix);