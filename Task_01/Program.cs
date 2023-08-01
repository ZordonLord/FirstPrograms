// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.Write("Введите число 1:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2*number2)

{
Console.WriteLine("да:1ое число является квадратом 2го числа");
}
else
{
 Console.WriteLine("нет:1ое число не является квадратом 2го числа");   
}