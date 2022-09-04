/* Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/

int m = 1;
int n = 15;
if (m % 2 != 0)
{
    m = m + 1;
}
Console.WriteLine(SumEvenNumbers(m, n));

int SumEvenNumbers(int m, int n)
{
    if (n >= m)
    {
        return m + SumEvenNumbers(m + 2, n);
    }
    else return 0;
}
