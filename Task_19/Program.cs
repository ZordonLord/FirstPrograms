// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrom(int num)
{
    if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10) return true;
    return false;
}

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 9999 && number < 100000) || (number > -100000 && number < -9999))
{
    bool palindrom = Palindrom(number);

    if (palindrom == true) Console.WriteLine($"Число {number} является палиндромом");
    else Console.WriteLine($"Число {number} не является палиндромом");
}
else
{
    Console.WriteLine("Введено некорректоное число");
}
