/* Задача 58
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int m = 2;
int n = m;
int[,] firstMatrix = new int[m, n];
int[,] secondMatrix = new int[m, n];

FillArray(firstMatrix);
PrintArray(firstMatrix);
Console.WriteLine();
FillArray(secondMatrix);
PrintArray(secondMatrix);
Console.WriteLine();
PrintArray(ResultMatrix(firstMatrix, secondMatrix));



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

int[,] ResultMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] resultMatrix = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum = sum + firstArray[i, k] * secondArray[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}




