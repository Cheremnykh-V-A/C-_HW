﻿// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


uint N = 8;

void PrintNto1(uint N)
{
    Console.Write(N + " ");
    
    if (N <= 1) return;
    PrintNto1 (N - 1);
}

PrintNto1(N);