// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] MyArray (int lenght, int leftRange, int rightRange)
{
    int[] array = new int[lenght];

    for(int i = 0; i < lenght; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}

int DifferenceMaxMin (int[] array)
{
    int max = array[0];
    int min = array[0];
    int dif = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
        
        dif = max - min;
    }
    return dif;
}

int[] array = MyArray(5, 0, 100);
Console.WriteLine($"[{string.Join(", ", array)}]");

int difference = DifferenceMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным значением = {difference}");