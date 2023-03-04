// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int rows = ReadNumber("Введите количество строк");
int colums = ReadNumber("Введите количество столбцов");

int[,] matrix = new int [rows, colums];

void FillArray(int [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(0, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void AveregeMethod(int[,] matrix)
{
    
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        double averege = 0;

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            averege = (averege + matrix [i, j]);
        }
        averege = averege / rows;
        Console.Write(Math.Round(averege, 1) + " ");
    }
    Console.WriteLine();
}


FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Среднее арифметическое каждого столбца:");
AveregeMethod(matrix);



