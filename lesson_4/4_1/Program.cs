//Задайте одномерный массив, заполненный случайными числами.
//Определите количество простых чисел в этом массиве.
//(Простое число делится на 1 и на себя.)

//Создаем объект Random для генерации случайных чисел
Random random = new Random();

//Создаем массив из 10 случайных чисел
int[] numbers = new int[10];
for (int i = 0; i < numbers.Length; i++)
{
    //Генерация случайных чисел от 1 до 100
    numbers[i] = random.Next(1, 100);
}

//Определение количества простых чисел в массиве
int count = 0;
foreach (var number in numbers)
{
    if (IsPrime(number))
    {
        Console.WriteLine(number);
        count++;
    }
}

//Вывод результата
Console.WriteLine("Количество простых чисел в массиве: " + count);

//Метод для определения, является ли число простым
static bool IsPrime(int number)
{
    if (number < 2)
        return false;
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}
