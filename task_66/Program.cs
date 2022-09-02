/* Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/

int m = 4;
int n = 8;
if (m % 2 != 0)
{
    m = m + 1;
}
Console.WriteLine(SumEvenNumbers(m, n));

int SumEvenNumbers(int n, int m)
{
    if (n <= m)
    {
        return n + SumEvenNumbers(n + 2, m);
    }
    else return 0;
}

