// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и
// 2. выдаёт произведение чисел от 1 до N.
// Пример:
// 4 -> 24
// 5 -> 120

System.Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int findFactorial(int num)
{
    int factorial = 1;
    for(int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    return factorial;
}
int result = findFactorial(number);
System.Console.WriteLine($"{result}");