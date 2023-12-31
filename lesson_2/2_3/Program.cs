// задание 3. Написать программу, которая принимает на вход два числа
// и выводит, является ли второе число кратным первому числу.
// Если нет, то выводит остаток от деления.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

int ostatok = a % b;
if (ostatok == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет, " + ostatok);
}
