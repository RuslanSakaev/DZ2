// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введи цифру от 1 до 7, обозначающую день недели: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayOfTheWeek)
{
    if (dayOfTheWeek == 6 || dayOfTheWeek == 7)
    {
        Console.WriteLine("это выходной день");
    }
    else if (dayOfTheWeek < 1 || dayOfTheWeek > 7)
    {
        Console.WriteLine("данное значение выходит за количество дней в неделе");
    }
    else Console.WriteLine("этот день не выходной");
}

CheckingTheDayOfTheWeek(dayOfTheWeek);

