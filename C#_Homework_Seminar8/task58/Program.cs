// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

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
int size = InputInt("Введите размерность матриц:");

int[,] matrixA = new int [size, size];
int[,] matrixB = new int [size, size];

FillArray(matrixA);
FillArray(matrixB);

int[,] matrixC = new int [size, size];

for (int i = 0; i < size; i++)
{
    for(int j = 0; j < size; j++)
    { 
        matrixC[i, j] += matrixA[i, j] * matrixB[i, j];
    }
}



PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintMatrix(matrixC);






