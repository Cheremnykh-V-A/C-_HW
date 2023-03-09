﻿// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы 
// каждой строки двумерного массива.
// 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int rows = ReadNumber("Введите число строк");
int colums = ReadNumber("Введите число столбцов");

int[,] myMatrix = new int [rows, colums];

void FillArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(0, 10);
        }
    }
}

void PrintMatrix (int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SortingAnArrayString (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] > matrix[i, k + 1])
                {
                    int temp = 0;
                    temp = matrix[i, k];
                    matrix[i, k] = matrix [i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
}

FillArray (myMatrix);
PrintMatrix (myMatrix);
Console.WriteLine();
Console.WriteLine("Массив с упорядочными строками:");
SortingAnArrayString(myMatrix);
PrintMatrix(myMatrix);

