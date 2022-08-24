//Задача 21
//Напишите программу, которая принимает на вход координаты двух
//точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А");
double Ax = double.Parse(Console.ReadLine());
double Ay = double.Parse(Console.ReadLine());
double Az = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки В");
double Bx = double.Parse(Console.ReadLine());
double By = double.Parse(Console.ReadLine());
double Bz = double.Parse(Console.ReadLine());

double Distance = Math.Pow(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2) + Math.Pow((Bz - Az), 2), 0.5);
Console.WriteLine($"Расстояние между точками = {Distance}");