// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadNumber (string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] ReadArray (int lenght)
{
    int[] array = new int[lenght];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = ReadNumber("Введите i-ый элементы массива");
    }
    return array;
}

int CountPositiveElements(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

int M = ReadNumber("Введите длину массива");
int[] myArrray = ReadArray(M);
int result = CountPositiveElements(myArrray);
Console.WriteLine($"Было введено {M} чисел, из них положительных - {result}");


