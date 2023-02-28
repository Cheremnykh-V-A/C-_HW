// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] MyArray(int lenght, int leftRange, int rightRange)
{
    int[] array = new int[lenght];

    for(int i = 0; i < lenght; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}

int SumElements (int[] array)
{
    int count = 0;
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
        count++;
    }
    return sum;
}

int[] array = MyArray(4, -10, 10);

Console.WriteLine($"[{string.Join(", ", array)}]");

int SumUnevenIndex = SumElements(array);

Console.WriteLine(SumUnevenIndex);