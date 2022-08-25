/* Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/
Console.WriteLine("Введите значение M - количество чисел, которое необходимо ввести далее для обработки: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[] array = new int[userNumber];
FillArray(array);
int count = 0;
Console.WriteLine($"Вы ввели {PositiveResult(array)} положительных числа");

void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = Convert.ToInt32(Console.ReadLine());
    }
}

int PositiveResult(int[] inarray)
{
    for (int i = 0; i < inarray.Length; i++)
    {
        if (inarray[i] > 0)
        {
            count++;
        }
    }
    return count;
}


