// Задача 33: 
// 1. Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// Пример:
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


Console.WriteLine("Введите искомое число в массиве ");
int number = Convert.ToInt32(Console.ReadLine());

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

bool IfNumberPresentInArray(int[] array, int num)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        {
            result = true;
            break;
        }
    }
    return result;
}

int[] arr = CreateArrayRndInt(20, -9, 9);
PrintArray(arr);
bool result = IfNumberPresentInArray(arr, number);
if(result == true)
{
    Console.WriteLine("Заданное число есть в массиве");
}
if(result == false)
{
    Console.WriteLine("Заданного числа нет в массиве");
}