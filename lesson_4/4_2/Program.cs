//Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
//Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

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

//функция подсчета количества элементов массива по заданным условиям
int MyFunction(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
            count++;
    }
    return count;
}

Console.Write("Введите количество случайных целых чисел массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите первый элемент (число) массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите последний элемент (число) массива: ");
int stop = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num, start, stop);
Print(mass);
int result = MyFunction(mass);
Console.WriteLine("Количество чисел, которые оканчиваются на 1 и делятся нацело на 7: " + result);
