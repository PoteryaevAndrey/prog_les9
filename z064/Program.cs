﻿/*Задача 64: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


Console.WriteLine("Введите натуральное число больше 1:");
int N = int.Parse(Console.ReadLine()!);

string PrintNumber(int N)
{
    if (N == 1) return N.ToString();
    return (N + " " + PrintNumber(N-1));
}
Console.Write(PrintNumber(N));
