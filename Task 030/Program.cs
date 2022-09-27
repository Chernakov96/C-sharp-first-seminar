// Задача 30: Напишите программу, которая
// 1. выводит массив из 8 элементов, 
// 2.заполненныйнулями и единицами в случайном порядке.
// Пример:
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

void FillArrayRandom()
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        array[i] = Random().Next(0, 2);
    }
}

FillArrayRandom;

