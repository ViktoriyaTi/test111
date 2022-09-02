/* Задача 64: 
Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.

M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/

Console.WriteLine(DescendingValue(2, 10));

string DescendingValue(int minValue, int maxValue)
{
    if (minValue <= maxValue)
    {
        return $"{maxValue} " + DescendingValue(minValue, maxValue - 1);
    }
    else
    {
        return String.Empty;
    }
}


