/*
Написать программу, которая  по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y)
*/


Console.WriteLine("Введите номер четверти: ");
int quator = Convert.ToInt32(Console.ReadLine());
if (quator == 1)
{
    Console.WriteLine("x < 0, y < 0");
}
else if (quator == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if (quator == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if (quator == 4)
{
    Console.WriteLine("x > 0, y < 0");
}
else
{
    Console.WriteLine("Задана неверная четверть.");
}