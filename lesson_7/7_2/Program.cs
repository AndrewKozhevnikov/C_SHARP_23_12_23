﻿// Задайте значение N. Написать программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// Использовать рекурсию.

void Rec(int a)
{
    if (a != 0)
    {
        Rec(a - 1);
        Console.Write($"{a} ");
    }
}

Rec(10);