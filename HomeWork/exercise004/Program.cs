﻿/*8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число:"); 
string number = Console.ReadLine();
int numberN = int.Parse(number);

for (int i = 2; i <= numberN; i++)
if (i % 2==0)
{
    Console.Write(i);
    Console.WriteLine();
}