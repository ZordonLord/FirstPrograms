﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (99 < number && number < 1000)
{
    int res = (number % 100) / 10;
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Некорректное число");
}