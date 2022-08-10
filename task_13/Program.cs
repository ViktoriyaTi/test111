/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int remainder;
int division;

if (userNumber < 100)
{
    Console.WriteLine("Третьей цифры введенного числа - нет");
}
else
{
    if (userNumber > 100 & userNumber <= 999)
    {
        remainder = userNumber % 10;
        Console.WriteLine($"Третья цифра введенного числа - {remainder}");
    }
    else if (userNumber > 999 & userNumber <= 9999)
    {
        remainder = userNumber / 10;
        division = remainder % 10;
        Console.WriteLine($"Третья цифра введенного числа - {division}");
    }
    
    else if (userNumber > 9999 & userNumber <= 99999)
    {
        remainder = userNumber / 100;
        division = remainder % 10;
        Console.WriteLine($"Третья цифра введенного числа - {division}");
    }
     else if (userNumber > 99999 & userNumber <= 999999)
    {
        remainder = userNumber / 1000;
        division = remainder % 10;
        Console.WriteLine($"Третья цифра введенного числа - {division}");
    }
    else Console.WriteLine("Вы ввели слишком большое число!");
}
    