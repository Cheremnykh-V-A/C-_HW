// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] MyArray(int lenght, int leftValue, int rightValue)
{
    int[] array = new int[lenght];

    for(int i = 0; i < lenght; i++)
    {
        array[i] = Random.Shared.Next(leftValue, rightValue +1);
    }
    return array;
}

int Even(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

int[] array = MyArray(6, 100, 1000);
Console.WriteLine($"[{string.Join(", ", array)}]");

int evenNum = Even(array);

Console.WriteLine($"Количество чётных числе в массиве: {evenNum}");

