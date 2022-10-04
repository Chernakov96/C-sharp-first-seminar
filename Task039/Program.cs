﻿// Задача 39: Напишите программу, которая 
// 1. перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [6 7 3 6] -> [6 3 7 6]

//Array.Reverse(arr);

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

void ReverseArray(int[] array)
{
    int size = array.Length; // 5
    int index1 = 0;
    int index2 = size - 1;
    //  0 1 2 3 4      0 1 2 3 4
    // [1 2 3 4 5] -> [5 4 3 2 1]
    while (index1 < index2)
    {
        int obj = array[index1]; //2
        array[index1] = array[index2]; //2 -> 4
        array[index2] = obj; // 2

        index1++;
        index2--;
    }
}

void ReverseArray2(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size / 2; i++)
    {
        int obj = array[i];
        array[i] = array[size - 1 - i];
        array[size - 1 - i] = obj;
    }
}

int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);
ReverseArray2(array);
PrintArray(array);