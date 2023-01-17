// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.


Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 % num2 == 0) Console.WriteLine($"Число {num1} кратно числу {num2}");
else {
        int hex = num1 % num2;
        Console.WriteLine($"Остаток от дления {num1} на {num2} = {hex}");
} 