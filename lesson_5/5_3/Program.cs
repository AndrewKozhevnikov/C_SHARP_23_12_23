// Задайте двумерный массив из целых чисел.
// Сформируйте новый одномерный массив, состоящий из средних
// арифметических значений по строкам двумерного массива.

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

double[] Average(int[,] array) // Функция подсчета среднего арифметического срок двумерного массива
{
    double sum = 0;
    double[] newMass = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sum = sum + array[i, j];
        newMass[i] = sum / array.GetLength(1);
        sum = 0;
    }
    return newMass;
}

void Print(double[] arr) // Функция вывода одномерного массива
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

Print(Average(matrix));
