// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные и
// замените эти элементы на их квадраты.

int[,] CreateMatrix(int rowCount, int columsCount) // Функция создания массива
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix) // Функция вывода массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4); // Точка входа в программу, создание массива случайных чисел
ShowMatrix(matrix); // Вывод массива случайных чисел на экран

void EvenIndexMatrix(int[,] array) // Функция замены элементов с четными индексами на квадрат их значения
{
    for (int i = 0; i < array.GetLength(0); i += 2) // идем по четным индексам
    {
        for (int j = 0; j < array.GetLength(1); j += 2) // идем по четным индексам
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
}

EvenIndexMatrix(matrix); // Изменение первоначального массива по функции
ShowMatrix(matrix); // Вывод измененного массива на экран
