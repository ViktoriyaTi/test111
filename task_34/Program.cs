/* Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве:= {SumEvenNumbers(array)}");


void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] col)
{
    for (int count = 0; count < col.Length; count++)
    {
        Console.Write(col[count] + " ");
    }
}

int SumEvenNumbers(int[] arr)
{
    int amount = 0;
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] % 2 == 0)
        {
            amount = amount + 1;
        }
    }
    return (amount);
}
