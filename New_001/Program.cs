Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int count = -number;
while( count <= number )
{
    Console.Write($"{count} ");
    count++;
}