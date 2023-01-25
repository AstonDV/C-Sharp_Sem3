// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// d = √ (х А – х В) 2 + (у А – у В) 2

Console.Clear();

Console.WriteLine("Введите координаты первой точки");
Console.Write("Введите координату x: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты второй точки");
Console.Write("Введите координату x: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y: ");
int y2 = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
// result = Math.Round(result, 2);
Console.WriteLine($"Расстояние между точками равно {result:f3}");