﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(double[,] array)
{
for (int i =0;i<array.GetLength(0);i++)
for (int j =0;j<array.GetLength(1);j++)
array[i,j] = new Random().NextDouble();
}

void PrintArray(double[,] array)
{
for (int i =0;i<array.GetLength(0);i++)
{
for (int j =0;j<array.GetLength(1);j++)
Console.Write($"{array[i,j],20} ");
System.Console.WriteLine();
}
}




Console.Clear();
System.Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов ");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows,cols];
FillArray(array);
PrintArray(array);