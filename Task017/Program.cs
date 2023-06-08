/*
Написать программу, которая принимает на вход координаты точки (X и Y),
причем X != 0 и Y != 0 и выдает номер четверти плоскости, в которой 
находится эта точка.
*/

// Подзадачи:
// 1. Принять на вход координаты X и Y;
// 2. Проверить, что X != 0, Y !=0;
// 3. Проверить четверть наших координат;
// 4. Вывод.

int [] points = new int[2];
Console.WriteLine("Введите координаты x и y: ");
for (int i = 0; i < points.Length; i++)
{
    points[i] = Convert.ToInt32(Console.ReadLine());
    if (points[i] == 0)
    {
        break;
    }
}
if (points[0] > 0 && points[1] > 0)
{
    Console.WriteLine("1-я четверть");
}
else if (points[0] < 0 && points[1] > 0)
{
    Console.WriteLine("2-я четверть");
}
else if (points[0] < 0 && points[1] < 0)
{
    Console.WriteLine("3-я четверть");
}
else if (points[0] > 0 && points[1] < 0)
{
    Console.WriteLine("4-я четверть");
}
else
{
    Console.WriteLine("x = 0, y = 0");
}

