﻿/*
Написать программу, которая принимает на вход число (N)
и выдает таблицу квадратов чисел от 1 до N. 
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i} ");
}