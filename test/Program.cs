/* 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
(на примерах демонстрация выводов 5 и 3 размерных массивов, вам же нужно сделать 8)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

string[] array = new string[] { "1", "234", "floor", "cat", "2", "45", "777", "hello" };
string[] newArray = new string[array.Length];
FillArray(array,newArray);
PrintArray(newArray);


void FillArray(string[] array, string[] newArray)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }

    }

}

void PrintArray(string[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}
