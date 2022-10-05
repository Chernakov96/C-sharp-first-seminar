// Задача 44: 
// 1. Не используя рекурсию, 
// 2. выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Пример:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите положительное целое число ");
int fibonacciNumber = Convert.ToInt32(Console.ReadLine());

int[] Fibonacci(int num)
{
    int[] fibonacciArray = new int[num];
    fibonacciArray[0] = 0;
    fibonacciArray[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
    }
    return fibonacciArray;
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
int[] result = Fibonacci(fibonacciNumber);
PrintArray(result);


//Решение из семинара
// Console.Write("Введите целое положительное число:");
// int numA = Convert.ToInt32(Console.ReadLine());

// void Fibonacci(int num)
// {
//     int num1 = 0;
//     int num2 = 1;
//     int num3 = default;
//     Console.Write($"N = {numA} -> {num1} {num2}");
//     for (int i = 2; i < num; i++)
//     {
//         num3 = num1 + num2;
//         Console.Write($" {num3}");
//         num1 = num2;
//         num2 = num3;

//     }
// }

// Fibonacci(numA);