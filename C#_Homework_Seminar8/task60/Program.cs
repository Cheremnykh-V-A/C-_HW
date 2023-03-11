// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int ReadNumber(string messageToUser)
{
  Console.Write(messageToUser);
  int value = Convert.ToInt32(Console.ReadLine());
  return value;
}

Console.WriteLine("Введите размер трёхмерного массива(XYZ):");
int X = ReadNumber("Введите X: ");
int Y = ReadNumber("Введите Y: ");
int Z = ReadNumber("Введите Z: ");

int[,,] matrix = new int[X,Y,Z];

void FillArray(int[,,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int digit = Random.Shared.Next(1, 100);
                matrix[i, j, k] += digit;
            }
        }
   }
}

void PrintMatrix (int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) ");
            }
        }
    }
}

FillArray(matrix);
PrintMatrix(matrix);