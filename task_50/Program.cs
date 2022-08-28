/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
(на вход именно поступает позиция элемента, можете разбить на две переменные или прописать в одну строку и конвертировать в два числа, комментарии в конце семинара по этой задаче)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);

Console.WriteLine("Введите номер строки: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int l = Convert.ToInt32(Console.ReadLine());
Position(array, k, l);

void Position(int[,] array, int rows, int columns)
{
    int i = 0;
    int j = 0;
    if (i <= rows &&
    rows <= array.GetLength(0) &&
    j <= columns &&
    columns <= array.GetLength(1))
    {
        Console.Write($"Введенная позиция {rows},{columns} содержит значение {array[rows, columns]}");
    }
    else { Console.WriteLine($"Такой позиции {rows},{columns} в массиве нет"); }
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
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

