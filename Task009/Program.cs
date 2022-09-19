// Task 9. Напишите программу, которая 
// 1.выводит случайное число из отрезка [10, 99]
// 2. показывает наибольшую цифру числа.
// 3. вывести результат
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100); // функция - метод, возвращающий значение
// System.Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");// процедурный метод, не возвращает значение
// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if(firstDigit == secondDigit) System.Console.WriteLine("Цифры одинаковые");
// if(firstDigit > secondDigit) Console.WriteLine(($"Наибольшая цифра числа {number} => {firstDigit}"));
// else Console.WriteLine($"Наибольшая цифра числа {number} => {secondDigit}");

// int maxDigit = 0;
// if (firstDigit > secondDigit) maxDigit = firstDigit;
// else maxDigit = secondDigit;

// int max = firstDigit > secondDigit ? firstDigit : secondDigit; //Тернарный оператор

int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10; 

    //if(firstDigit > secondDigit) return firstDigit;
    //return secondDigit;
    if(IsEqualDigits(firstDigit, secondDigit)) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

bool IsEqualDigits(int num1, int num2)
{
    return num1 == num2;
}

int maxDigit = MaxDigit(num);
string result = maxDigit != 0 ? maxDigit.ToString() : "Цифры одинаковые";
Console.WriteLine($"Наибольшая цифра числа {num} => {maxDigit}");