/* Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double[] array = new double[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разность между max {MaxNumber(array)} и min {MinNumber(array)} элементами = {MaxNumber(array)- MinNumber(array)}");

void FillArray(double[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(100);
    }
}

void PrintArray(double[] col)
{
    for (int count = 0; count < col.Length; count++)
    {
        Console.Write(col[count] + " ");
    }
}

double MaxNumber(double[] arr)
{
    double max = array[0];

    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] > max)
        {
            max = arr[j];
        }
    }
    return (max);
}

double MinNumber(double[] array1)
{
    double min = array1[0];
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] < min)
        {
            min = array1[i];
        }
    }
    return (min);
}


