// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

string DivideBy7And23(int num)
{
    if(num %7 == 0 && num % 23 == 0)
     {
       return Console.WriteLine($"Число {num} кратно 7 и 23");
     }
    return Console.WriteLine($"Число {num} не кратно 7 и 23"); 
}
string result = DivideBy7And23(number);