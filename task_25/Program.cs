/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.WriteLine("Введите первое число: ");
int userNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int userNumberB = Convert.ToInt32(Console.ReadLine());

int FindPowerNumber (int numberA, int numberB)
{
    int power = 0;
    power = Convert.ToInt32(Math.Pow(userNumberA, userNumberB));
    return power;
}

Console.WriteLine($"Число {userNumberA},возведенное в степень {userNumberB} = {FindPowerNumber(userNumberA, userNumberB)} ");