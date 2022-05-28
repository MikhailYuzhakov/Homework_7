/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

double[,] array = new double[1000,1000];
int i = 0, j = 0, m = 0, n = 0;
Random rand = new Random();

Console.Clear();
Console.WriteLine("Введите размерность массива MxN с клавиатуры через пробел: ");
int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
m = size[0];
n = size[1];

for (i = 0; i < size[1]; i++)
    for (j = 0; j < size[0]; j++)
        array[i,j] = rand.NextDouble();

for (i = 0; i < size[1]; i++) {
    for (j = 0; j < size[0]; j++)
        Console.Write(Math.Round(array[i,j], 2) + " ");
    Console.WriteLine();
}

Console.WriteLine("Введите позицию элемента M и N для вывода с клавиатуры через пробел: ");
int[] size_1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

if (size_1[0] > size[0] || size_1[1] > size[1]) Console.WriteLine("Элемента нет");
else Console.WriteLine("Элемент " + Math.Round(array[size_1[0], size_1[1]], 2));

