Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
if ( x == 1 ) Console.WriteLine("Понедельник");
if ( x == 2 ) Console.WriteLine("Вторник");
if ( x == 3 ) Console.WriteLine("Среда");
if ( x == 4 ) Console.WriteLine("Четверг");
if ( x == 5 ) Console.WriteLine("Пятница");
if ( x == 6 ) Console.WriteLine("Суббота");
if ( x == 7 ) Console.WriteLine("Воскресенье");
if ( x > 7 || x < 1)
{
    Console.Write($"Дня недели с номером {x} нет!");
}