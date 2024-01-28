// Создайте массив символов типа char.
// Создайте строку из символов этого массива.

string Concat(char[] mass)
{
    string buf = "";
    for (int i = 0; i < mass.Length; i++)
        buf = buf + mass[i];
    return buf;
}

char[] charArr = {'H', 'e', 'l', 'l', 'o'};
string result = Concat(charArr);
Console.WriteLine(result);
