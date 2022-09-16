Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 7)
{
    Console.WriteLine("Вы ввели некорректное число");
}
if(num == 1)
{
    Console.WriteLine("пн");
}
if(num == 2)
{
    Console.WriteLine("вт");
}
if(num == 3)
{
    Console.WriteLine("ср");
}
if(num == 4)
{
    Console.WriteLine("чт");
}
if(num == 5)
{
    Console.WriteLine("пт");
}
if(num == 6)
{
    Console.WriteLine("сб");
}
if(num == 7)
{
    Console.WriteLine("вс");
}


switch(num)
{
    case 1:
    Console.WriteLine("пн");
    break;
    case 2:
    Console.WriteLine("вт");
    break;
    case 3:
    Console.WriteLine("ср");
    break;
    case 4:
    Console.WriteLine("чт");
    break;
    case 5:
    Console.WriteLine("пт");
    break;
    case 6:
    Console.WriteLine("сб");
    break;
    case 7:
    Console.WriteLine("вс");
    break;
    default:
        Console.WriteLine()
}
