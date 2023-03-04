// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int n = ReadNumber("Введите номер строки");
int m = ReadNumber("Введите номер столбца");

const int ROWS = 4;
const int COLUMS = 4;

int[,] matrix = new int[ROWS, COLUMS]; 

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

void result(int[,] matrix)
{
    if (n < matrix.GetLength(0) || m < matrix.GetLength(1))
    {
        Console.WriteLine($"Элемент в этой троке и это столбце = {matrix[n -1, m -1]}");
    }
    else 
    {
        Console.WriteLine("Такого элемента нет");
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

FillArray(matrix);
PrintArray(matrix);
result(matrix);


