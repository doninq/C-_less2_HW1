/* 
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите день недели от одного до семи: ");
int DayNum = Convert.ToInt32(Console.ReadLine()!);
if (DayNum > 7 | DayNum < 1)
{
    Console.WriteLine("Вы ввели что то не то...");
}
else
{
    if (DayNum > 0 && DayNum < 6)
    {
        Console.WriteLine("Будни");
    }
    if (DayNum > 5 && DayNum < 8)
    {
        Console.WriteLine("Выходные");
    }

}
