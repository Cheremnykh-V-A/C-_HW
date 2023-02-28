// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.WriteLine("Не подходит, введи другую цифру)");
}
else
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Да! Это выходной!");
    }
    else 
    {
        Console.WriteLine("Нет, это рабочий день(");
    }
}