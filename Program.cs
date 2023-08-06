﻿int numberA = new Random().Next(1,20);
Console.WriteLine(numberA);
int numberB = new Random().Next(1,20);
Console.WriteLine(numberB);
int numberC = new Random().Next(1,20);
Console.WriteLine(numberC);
int max = numberA;
if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}
System.Console.WriteLine(max);

