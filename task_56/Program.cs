/* Задача 56
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
int[] collection = RowSumm(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinRowIndex(collection) + 1}");


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

int[] RowSumm(int[,] array)
{
    int[] summArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summArray[i] = summArray[i] + array[i, j];
        }
    }
    return summArray;
}

int MinRowIndex(int[] array)
{
    int minimalSum = array[0];
    int index = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minimalSum)
        {
            minimalSum = array[i];
            index = i;
        }
    }
    return index;
}
