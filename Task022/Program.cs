/*
Написать программу, которая принимает на вход число (N)
и выдает таблицу квадратов чисел от 1 до N. 
*/

/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i} ");
}
*/

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

for(int i = 0; i <= N; i++)
{
    array[i] = (i + 1) * (i + 1);
    Console.WriteLine(array[i]);
}