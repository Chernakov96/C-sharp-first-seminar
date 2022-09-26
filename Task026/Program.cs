// Задача 26: Напишите программу, которая 
// 1.принимает на вход число и 
// 2. выдаёт количество цифр в числе.
// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int sumOfDigits(int num)
{
    int count = 0;
    while(num != 0)
    {
        num = num /10;
        count++;
    }
    return count;
}
int result = sumOfDigits(number);
System.Console.WriteLine($"{result}");