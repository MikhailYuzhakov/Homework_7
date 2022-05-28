/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

double[,] array = new double[1000,1000];
int i = 0, j = 0;
Random rand = new Random();

Console.Clear();
Console.WriteLine("Введите размерность массива MxN с клавиатуры через пробел: ");
int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (i = 0; i < size[1]; i++)
    for (j = 0; j < size[0]; j++)
        array[i,j] = rand.NextDouble();

for (i = 0; i < size[1]; i++) {
    for (j = 0; j < size[0]; j++)
        Console.Write(Math.Round(array[i,j], 2) + " ");
    Console.WriteLine();
}
