// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

string dayoff = Dayoff(number);
Console.WriteLine(dayoff);

string Dayoff(int numb)
{
    if (numb > 0 && numb <= 7)
    {
        return numb == 6 || numb == 7 ? "Да" : "Нет";
    }
    return "Некорректный день недели";
}