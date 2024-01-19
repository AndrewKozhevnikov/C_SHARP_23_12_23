//Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве.
//Программа должна выдать ответ: да / нет.

int[] arr = { 1, 3, 4, 19, 3 };

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
bool a = false;

for (int i = 0; i < arr.Length; i++)
{
    if (number == arr[i])
    {
        a = true;
        break;
    }
}
if (a)
    Console.Write("да");
else
    Console.Write("нет");
