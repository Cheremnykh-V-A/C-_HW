// Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int rows = 4;
int columns = 4;

int[,] spiralMatrix = new int [rows, columns];

void FillSpiralArray(int [,] matrix)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    
    while (temp <= rows * columns)
    {
        spiralMatrix[i, j] = temp;

        if (i <= j + 1 && i + j < columns - 1)
        {
            j++;
        }

        else if (i < j && i + j >= rows - 1)
        {
            i++;
        }

        else if (i >= j && i + j > columns - 1)
        {
            j--;
        }

        else
        {
            i--;
        }

        temp++;
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

FillSpiralArray(spiralMatrix);
PrintMatrix(spiralMatrix);