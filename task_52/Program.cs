/* Задача 52. 
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int m = 3;
int n = 4;

int[,] array = new int[m, n];
FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.Write($"Среднее арифметическое каждого столбца: ");
ArithmeticMeanColumns(array);

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}

void ArithmeticMeanColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summColumn = 0;
        double arithmeticColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summColumn = summColumn + array[i, j];
            arithmeticColumn = summColumn / m;
        }
        Console.Write($"{Math.Round(arithmeticColumn, 2)} ");
    }
}

