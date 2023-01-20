// Задача No21. Работа в группах
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21

// Координаты точки А от х1 до у1 =)
Console.WriteLine("Введите координаты точки А по X: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки A по Y: ");
int y1 = int.Parse(Console.ReadLine()!);
// Координаты точки В от х2 до у2 =)
Console.WriteLine("Введите координаты точки B по X: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки B по Y: ");
int y2 = int.Parse(Console.ReadLine()!);

 // d = √ (х А – х В) 2 + (у А – у В) 2
double result = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));
result = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Нашли расстояние между точками А и B {result}");

// Более сокращенный вариант 
// Console.WriteLine($"Нашли расстояние между точками А и B {Math.Round(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2)), 2, MidpointRounding.ToZero)}");