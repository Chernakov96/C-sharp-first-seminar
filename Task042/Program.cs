// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// Пример:
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите целое положительное число ");
int number = Convert.ToInt32(Console.ReadLine());

void ConvertToBinary(int num)
{
    string bin = string.Empty;
    if (num > 0)
    {
        bin += num % 2;
        ConvertToBinary(num / 2);
    }
    Console.Write(bin);
}

void ConvertToBinary2(int num)
{
    int[] array = new int[];
    

}


ConvertToBinary(number);