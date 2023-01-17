// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
Console.Clear();
int number = new Random().Next(100, 1000);

int number1 = number / 100;
int number3 = number % 10;

int result = number1 * 10 + number3;

Console.WriteLine($"Трехзначное число {number}");
Console.WriteLine($"Из числа {number} -> получаем {result} удалили вторую цифру");
