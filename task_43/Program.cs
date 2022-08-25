/* Задача 43
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.WriteLine("Даны две прямые, заданные уравнениями Y = k1 * X + b1 и Y = k2 * X + b2");
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


if (k1 == 0 || k2 == 0 || (k1-k2) == 0)
{
    Console.WriteLine("Ошибка ! Измените значение k1 или k2");
}
else
{double X = Math.Round((b2 - b1)/(k1 - k2), 2);
double Y = Math.Round(k1 * X + b1, 2);
Console.Write($"Точка пересечения двух прямых Х = {X}, У ={Y}");
}