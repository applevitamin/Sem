// Задача No18. Работа в группах
// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).
Console.Clear();

Console.WriteLine("Введите четверть: ");
int num = int.Parse(Console.ReadLine()!);
if (num > 0 && num < 5)
{
    if (num == 1)
    {
        Console.WriteLine("Первая четверть, | X > 0 | Y > 0 |");
    }
    else
    {
        if (num == 2)
        {
            Console.WriteLine("Вторая четверть, | X < 0 | Y > 0 |");
        }
        else
        {
            if (num == 3)
            {
                Console.WriteLine("Третья четверть, | X < 0 | Y < 0 |");
            }
            else Console.WriteLine("Четвертая четверть, | X > 0 | Y < 0 |");
        }
    }

}
else Console.WriteLine("Неверное значение!");