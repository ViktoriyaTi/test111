/* Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SumEvenNumbers(array);


void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(-100, 100);
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
    int sum = 0;
    for (int index = 1; index < arr.Length; index = index + 2)
    {
        sum = sum + arr[index];
    }
    if (sum != 0)
    {
        Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях:= {sum}");
    }
    else
    {
        Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях = 0");
    }
    return (sum);
}

