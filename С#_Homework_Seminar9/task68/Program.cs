// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

uint M = 3;
uint N = 5;

uint AkkermanFunction(uint M, uint N)
{
    if (M == 0) return N + 1;
    else if (M > 0 && N == 0) return AkkermanFunction (M - 1, 1);
    return AkkermanFunction (M - 1, AkkermanFunction(M, N - 1));
}

uint result = AkkermanFunction(M, N);
Console.WriteLine(result);
