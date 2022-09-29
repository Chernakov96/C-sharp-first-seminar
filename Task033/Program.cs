// Задача 31: 
// 1. Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// 2. Найдите сумму отрицательных и положительных элементов массива.
// 3. Вывод результата
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
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

int[] GetSumPositiveNegativeELem(int[] array)
{
    int sumPositive = default;
    int sumNegative = default;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0 ) sumNegative += array[i];
        else sumPositive += array[i];
    }
    return new int[]{sumPositive, sumNegative};
}


int GetSumPositiveElem(int[] array)
{
    int sumPositive = default;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0 ) sumPositive += array[i];
    }
    return sumPositive; 
}

int GetSumNegativeElem(int[] array)
{
    int sumNegative = default;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0 ) sumNegative += array[i];
    }
    return sumNegative;
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int positiveElem = GetSumPositiveElem(arr);
int negativeElem = GetSumNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов  = {positiveElem}, сумма отрицательных элементов  = {negativeElem}");