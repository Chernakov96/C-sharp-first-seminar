// Задача 37: 
// 1. Задать и вывести массив
// 2. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] ArrayOfElemMultiplication(int[] array)
{
    int len = array.Length;
    int size = len / 2;
    if (len % 2 == 1) size++;
    
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[(array.Length - 1) - i];
    }
    if (len % 2 == 1) result[size - 1] = array[size - 1];

    return result;
}
var arraySize = new Random();
int[] arr = CreateArrayRndInt(arraySize.Next(2,10), -10, 10);
PrintArray(arr);
int[] result = ArrayOfElemMultiplication(arr);
PrintArray(result);