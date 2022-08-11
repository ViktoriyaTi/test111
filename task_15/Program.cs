/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите цифру от 1 до 7: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber >= 1 & userNumber <= 5)
{
    Console.WriteLine("Нет, этот день не является выходным");
}
else
{
    if (userNumber == 6 || userNumber == 7)
    {
        Console.WriteLine("Да, этот день является выходным");
    }
    else
    {
Console.WriteLine("Ошибка. Вы ввели цифру не в диапозоне от 1 до 7");
    }
}