//Заполните массив из N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.
//Сформируйте целое число, которое будет состоять из цифр массива.
//Старший разряд числа находится на 0-м индексе, младший - на последнем.

//функция формирования массива случайными целыми числами
int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

//функция вывода массива чисел
void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

//функция формирования числа по заданным условиям
long CreateNum(int[] arr)
{
    string num = "";
    foreach (int item in arr)
        num += item;
    return long.Parse(num);
}

Console.Write("Введите количество случайных целых чисел массива (не более 8): ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите первый элемент массива (от 0 до 9): ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите последний элемент массива (от 0 до 9): ");
int stop = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num, start, stop);
Print(mass);

long result = CreateNum(mass);
Console.WriteLine("Число, состоящее из цифр массива: " + result);
