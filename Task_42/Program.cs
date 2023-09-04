// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int DecimalToBin(int num) // 13
{
    int res = 0;
    int factor = 1;
    while(num > 0)   // 13 > 0 // 6 > 0 // 3 > 0 // 1 > 0 // 0 > 0
    {
        res += num % 2 * factor; // 0 + 13 % 2 * 1 = 1 // 1 + 6 % 2 * 10 = 1 // 1 + 3 % 2 * 100 = 101 // 101 + 1 % 2 * 1000 = 1101
        num /= 2; // 6 // 3 // 1 // 0
        factor *= 10; // 10 // 100 // 1000 // 10000
    }
    return res; // 1101
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int decimalToBin = DecimalToBin(number);
Console.WriteLine(decimalToBin);