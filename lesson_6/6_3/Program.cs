// Считать строку с консоли, состоящую из латинских букв в нижнем регистре.
// Выяснить, сколько среди введенных букв гласных.

int CountVowels(string input) // функция для подчсета количества гласных
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' }; //задаем массив с гласными
    int count = 0;
    foreach (char c in input) // проходим по каждому символу
    {
        if (Array.IndexOf(vowels, c) != -1)
            count++;
    }
    return count;
}

Console.WriteLine("Введите строку из латинских букв в нижнем регистре: "); //просим ввести строку
string input = Console.ReadLine()!;
int vowelCount = CountVowels(input);

Console.WriteLine($"Количесвто гласных букв в строке: {vowelCount}");
