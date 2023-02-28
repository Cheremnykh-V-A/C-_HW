// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// формула √ ((x2-x1)^2+ (y2-y1)^2+ (z2-z1)^2)

Console.WriteLine("Введите координаты по оси Х первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты по оси Y первой точки");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты по оси Z первой точки");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты по оси Х второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты по оси Y второй точки");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты по оси Z второй точки");
double z2 = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2- y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние между точками в 3D пространстве: {c}");