//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
int a1 = 5;
int b1 = 7;
int a2 = 2;
int b2 = 10;
int a3 = -9;
int b3 = -3;

int max1 = a1;
int min1 = a1;

int max2 = a2;
int min2 = a2;

int max3 = a3;
int min3 = a3;

if (a1 > max1) max1 = a1;
if (b1 > max1) max1 = b1;

if (a2 > max2) max2 = a2;
if (b2 > max2) max2 = b2;

if (a3 > max3) max3 = a3;
if (b3 > max3) max3 = b3;

if (a1 < min1) min1 = a1;
if (b1 < min1) min1 = b1;

if (a2 < min2) min2 = a2;
if (b2 < min2) min2 = b2;

if (a3 < min3) min3 = a3;
if (b3 < min3) min3 = b3;


Console.Write ("max1 = ");
Console.WriteLine (max1);

Console.Write ("min1 = ");
Console.WriteLine (min1);


Console.Write ("max2 = ");
Console.WriteLine (max2);

Console.Write ("min2 = ");
Console.WriteLine (min2);

Console.Write ("max3 = ");
Console.WriteLine (max3);

Console.Write ("min3 = ");
Console.WriteLine (min3);
