//Напишите программу, которая принимает 
//на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
Console.Write("Введи день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("(это день выходной) -> да");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("это день не означает день недели");
    }
    else Console.WriteLine("(это день не выходной) -> нет");
}
CheckingTheDayOfTheWeek(dayNumber);