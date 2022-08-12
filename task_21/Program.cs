/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Введите координаты первой точки X, Y, Z: ");
double X1 = Convert.ToDouble(Console.ReadLine());
double Y1 = Convert.ToDouble(Console.ReadLine());
double Z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки X, Y, Z: ");
double X2 = Convert.ToDouble(Console.ReadLine());
double Y2 = Convert.ToDouble(Console.ReadLine());
double Z2 = Convert.ToDouble(Console.ReadLine());

double distance = 0;
double differenceX = (X2 - X1)*(X2 - X1);
double differenceY = (Y2 - Y1)*(Y2 - Y1);
double differenceZ = (Z2 - Z1)*(Z2 - Z1);
distance = Math.Sqrt(differenceX + differenceY + differenceZ);

Console.WriteLine($"Расстояние между точками = {Math.Round(distance,2)}");


