/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
int count;
Console.WriteLine("Четные числа ");
for (count=2; count<=usernumber; count=count+2) 
Console.Write( $" {count},");
