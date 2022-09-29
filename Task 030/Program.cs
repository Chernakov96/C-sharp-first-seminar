// Задача 30: Напишите программу, которая
// 1. выводит массив из 8 элементов, 
// 2.заполненныйнулями и единицами в случайном порядке.
// Пример:
// [1,0,1,1,0,1,0,0]

Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] arrayGlobal = new int[num];

FillArrayRandom(arrayGlobal);
PrintArray(arrayGlobal);

void FillArrayRandom(int[] array)
{
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
array[i] = rnd.Next(0, 2);
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
Console.Write($"{array[array.Length - 1]}]");
}