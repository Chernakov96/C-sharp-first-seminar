// Задача 18: Напишите программу, которая 
// 1.по заданному номеру четверти, 
// 2.показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int numberOfQuarter = Convert.ToInt32(Console.ReadLine());

string FindRange(int num)
{
    if(num == 1) return "Диапазон X - от 0 до бесконенчости, Y - от 0 до бесконечности";
    if(num == 2) return "Диапазон X - от минус бесконенчости до 0, Y - от 0 до бесконечности";
    if(num == 3) return "Диапазон X - от минус бесконенчости до 0, Y - от минус бесконенчости до 0";
    if(num == 4) return "Диапазон X - от 0 до бесконенчости, Y - от минус бесконенчости до 0";
    return "Введено некорректное значение";
}
string range = FindRange(numberOfQuarter);
Console.WriteLine(range);