/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 0;
int userNumberPR = userNumber;
while (userNumberPR > 0)
{
    a = userNumberPR % 10;
    b = b * 10 + a;
    userNumberPR = userNumberPR / 10;
}
if (userNumber == b)
{
    Console.WriteLine($" Является палиндромом");
}
else
    Console.WriteLine($" Не является палиндромом");