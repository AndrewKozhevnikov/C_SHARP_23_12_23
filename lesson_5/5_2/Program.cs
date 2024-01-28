// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0), (1,1) и т.д.).

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

int SumDiagonal(int[,] array) // функция нахождения суммы элементов на главной диагонали (i = j)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
                sum = sum + array[i, j];
        }
    }
    return sum;
}

Console.Write(SumDiagonal(matrix));
