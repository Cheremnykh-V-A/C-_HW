// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (номер цифры считается от левого края)

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (numberA < 1000)
{
    int numberB = numberA % 10;

     Console.WriteLine($"Третья цифра - {numberB}");
}
else if (numberA < 10000)
{
    int numberC = numberA / 10 % 10;
    Console.WriteLine($"Третья цифра - {numberC}");
}
else if (numberA < 100000)
{
    int numberd = numberA / 100 % 10;
    Console.WriteLine($"Третья цифра - {numberd}");
}
else if (numberA < 1000000)
{
    int numberE = numberA / 1000 % 10;
    Console.WriteLine ($"Третья цифра - {numberE}");
}
else if (numberA > 999999)
{
    Console.WriteLine("Остановитесь, хватит меня мучать)");
}