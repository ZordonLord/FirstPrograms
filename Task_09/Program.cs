﻿// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10-99 -> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit2 = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit2}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if(firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}