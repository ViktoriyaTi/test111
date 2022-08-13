/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int remainder = 0;
int calculations = 0;
int userNumber2 = userNumber;
while (userNumber2 > 0)
{
    remainder = userNumber2 % 10;
    calculations = calculations * 10 + remainder;
    userNumber2 = userNumber2 / 10;
}
if (userNumber == calculations)
{
    Console.WriteLine($"Введенное число является палиндромом");
}
else
    Console.WriteLine($"Введенное число не является палиндромом");