// Задача 22: Напишите программу, которая
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу квадратов чисел от 1 до N.
// ПРимер:
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

void findDoubles(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int x2 = i*i;
        System.Console.WriteLine($"{x2}");
    }
}

findDoubles(number);

