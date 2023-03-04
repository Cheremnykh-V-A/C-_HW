// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool isLinesIntersect(double a, double b, double c, double d)
{
    return! (a == b);
}

(double, double) GetIntersectionPoint (double a, double b, double c, double d)
{
    double x = (d-c) / (a-b);
    double y = a * (d-c) / (a-b) + c;
    return (x, y);
}

int b1 = ReadNumber("Введите свободный член b1");
int k1 = ReadNumber("Введите угловой коэффициент k1");
int b2 = ReadNumber("Введите свободный член b2");
int k2 = ReadNumber("Введите угловой коэффициент k2");

if (isLinesIntersect(k1, k2, b1, b2) == true)
{
    (double x, double y) = GetIntersectionPoint(k1, k2, b1, b2);
    Console.WriteLine($"Точка пересечения находится по координатам: ({x}, {y})");
}
else
{
    Console.WriteLine("Прямые не пересекаются");
}
