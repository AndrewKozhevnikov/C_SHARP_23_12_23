// Задайте значение N. Написать программу,
// которая выведет все натуральные числа в промежутке от 1 до N.
// Использовать рекурсию.

string str1 = "aeyiou";

void Conson(string word, int i = 0)
{
    if (i == word.Length)
        return;
    if (str1.Contains(char.ToLower(word[i])) == false)
        Console.Write(word[i] + " ");
    Conson(word, i + 1);
}

Console.WriteLine("Enter letters: ");
string str2 = Console.ReadLine()!;
Conson(str2);
