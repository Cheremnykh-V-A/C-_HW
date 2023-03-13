// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadNumber (string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int rows = ReadNumber("Введите количество строк");
int columns = ReadNumber("Введите количество столбцов");

int[,] myMatrix = new int [rows, columns];
int minSum = Int32.MaxValue;
int indexRow = 1;
int indexRowMin = 0;

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
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

void SumOfStringElements (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j]; 
        }
        int count = 0;
        if (count < matrix.GetLength(0))
        {   
            if (sum < minSum)
            {
            minSum = sum;
            indexRowMin = indexRow;
            }
            indexRow++;
        }
        count++;
    }
}

FillArray(myMatrix);
PrintMatrix(myMatrix);
Console.WriteLine();
SumOfStringElements(myMatrix);
Console.WriteLine($"Строка с наименьшей суммой элементов = {indexRowMin}, её сумма = {minSum}");
