﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"{numberA} больше {numberB}");
}

if (numberB > numberA)
{
    Console.WriteLine($"{numberB} больше {numberA}");
}

if (numberA == numberB)
{
    Console.WriteLine("Данные числа равны");
}