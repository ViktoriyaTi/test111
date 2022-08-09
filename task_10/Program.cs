/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int numberdiv = userNumber/10;
int finishNumber = numberdiv % 10;
Console.WriteLine($"Вторая цифра числа: {finishNumber}");