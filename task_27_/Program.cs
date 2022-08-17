/* 
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int FindSumNumbers(int number)
{
    int sum = 0;
    int result = 0;
    while (number > 0)
    {
        number = Math.DivRem(number, 10, out result);
        sum = sum + result;
    }
    return sum;
}
Console.WriteLine($"Сумма цифр в числе {userNumber} = {FindSumNumbers(userNumber)} ");