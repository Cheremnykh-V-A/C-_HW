// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = ReadNumber("Введите число");

int result = 0;
while (number > 0)
{
    result += number % 10;
    number = number / 10;
}
Console.WriteLine($"Сумма всех цифр в данном числе равна {result}");




