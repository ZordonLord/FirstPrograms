// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountPositveNumInString(string[] message)
{
    int count = 0;
    for (int i = 0; i < message.Length; i++)
    {
        int num = Convert.ToInt32(message[i]);
        if (num > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите числа через запятую:");
string[] stringNumbers = Console.ReadLine()!.Split(',');

int countPositveNumInString = CountPositveNumInString(stringNumbers);
Console.WriteLine($"Введено чисел больше ноля: {countPositveNumInString}");