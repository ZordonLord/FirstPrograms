// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    if (num1 != 0 && num2 == 0) return AkkermanFunction(num1 - 1, 1);
    else return AkkermanFunction(num1 - 1, AkkermanFunction(num1, num2 - 1));
}

Console.WriteLine("Введите неотрицательное число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0 | number2 < 0)
{
    Console.WriteLine("Ошибка! Введены отрицательные числа.");
    return;
}
else
{
    int akkermanFunction = AkkermanFunction(number1, number2);
    Console.WriteLine(akkermanFunction);
}