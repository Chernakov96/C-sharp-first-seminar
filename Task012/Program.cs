// 12. Напишите программу, которая 
// 1.будет принимать на вход два числа
// 2.выводить, является ли второе число кратным первому
// 3. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

string result = num1 % num2 == 0 ? Console.WriteLine($"Число {num1} кратно числу {num2}") : Console.WriteLine($"Число {num1}  не кратно числу {num2} остаток от деления = {num1%num2}");

if ((numA % numB) == 0)
{
    Console.WriteLine($"Число {numA} кратно числу {numB}");
}
else
{ 
    Console.WriteLine($"Число {numA} не кратно числу {numB}, остаток от деления {numA % numB}"); 
}
