// Задача 24: Напишите программу, которая
// 1. принимает на вход число (А) и 
// 2.выдаёт сумму чисел от 1 до А.
// Пример:
// 7 -> 28
// 4 -> 10
// 8 -> 36

System.Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumNumbers(number);
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");

// int SumNumbers(int num)
// {
//     int sum = default;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }

int SumNumbers(int num)
{
    int sum = default;
    int count = 1;
    while (count <= num)
    {
       sum += count;
       count++; 
    }
    return sum;
}