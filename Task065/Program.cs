// Задача 65: 
// 1. Задайте значения M и N. Напишите программу, которая
// 2. выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8

Console.Write("Введите число M:  ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:  ");
int numberN = Convert.ToInt32(Console.ReadLine());
RangeNaturalNumbers(numberM, numberN);

void RangeNaturalNumbers(int num1, int num2)
{
    if (num1 < num2)
    {
        RangeNaturalNumbers(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        RangeNaturalNumbers(num1 - 1, num2);
    }
    if (num1 == num2)
    {
        Console.Write($"{num2} ");
    }
}
