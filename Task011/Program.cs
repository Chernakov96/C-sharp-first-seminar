// 11. Напишите программу, которая 
//1.выводит случайное трёхзначное число
//2.удаляет вторую цифру этого числа.
// 
// 456 -> 46
// 782 -> 72
// 918 -> 98

int rNumberum = new Random().Next(100, 1000);
Console.WriteLine($"{rNumberum}");

int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = (num - 100 * firstDigit) / 10;
    int thirdDigit = (num - 100 * firstDigit - secondDigit * 10);
    int deletedSecondDigit = firstDigit * 10 + thirdDigit;
    return deletedSecondDigit;
}

int deletedDigit = DeleteSecondDigit(rNumberum);
Console.WriteLine(deletedDigit);