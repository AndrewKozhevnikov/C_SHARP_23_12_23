﻿// Написать программу. На входе целое число N. На выходе все целын числа в промежутке от -N до N.

int N = 5;
int i = -N;

while (i <= N)
{
    Console.Write(i + " ");
    i = i + 1;
}