// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.Write("Введите номер дня недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

string dayName = getWeekName(dayNum);

Console.WriteLine($"{dayNum} день недели называется '{dayName}'");



string getWeekName(int dayNum)
{

    switch (dayNum)
    {
        case 1: return "Понедельник";
        case 2: return "Вторник";
        case 3: return "Среда";
        case 4: return "Четверг";
        case 5: return "Пятница";
        case 6: return "Суббота";
        case 7: return "Воскресенье";

        default:
            return "Неизвестный день недели";
    }
}