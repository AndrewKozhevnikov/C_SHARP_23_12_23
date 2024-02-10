// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
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
