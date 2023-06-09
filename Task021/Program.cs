/*
Написать программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве:
А (3, 6); В(2, 1) -> 5.09
A (7, -5); B(1, -1) -> 7.21
*/

Console.Write("Введите число х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

int squareX = (x2-x1)*(x2-x1);
int squareY = (y2-y1)*(y2-y1);

double lenth = Math.Sqrt(squareX + squareY);
Console.WriteLine($"Рсстояение меожду точками А и В = {(lenth):F2}");