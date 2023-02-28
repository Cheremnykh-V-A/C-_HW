// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число А в натуральную степень В
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
   int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

int numA = ReadNumber("Введите число А");
int numB = ReadNumber("Введите число В");

int numC = 1;

if (numB >= 0)
{
    for (int count = 0; count < numB; count++)  
    {
        numC *= numA;
    }
    Console.WriteLine($"Число {numA} в степени {numB} равняется {numC}");
}
else
{
    Console.WriteLine("Число В не может быть меньше 0");
}
