// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 4;
int N = 8;

int SumForMtoN (int M, int N)
{
    int sum = 0;
    if (M <= N)
    {
        sum = N + SumForMtoN(M, N - 1);
    }
    return sum;

}

int result = SumForMtoN(M, N);
Console.WriteLine(result);