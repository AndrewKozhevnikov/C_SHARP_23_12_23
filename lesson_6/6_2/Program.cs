// На основе символов строки (тип string)
// сформировать массив символов (тип char[]). Вывести массив на экран.

char[] StrToCharArr(string str)
{
    int length = str.Length;
    char[] arr = new char[length];
    for (int i = 0; i < length; i++)
        arr[i] = str[i];
    return arr;
}

string str1 = Console.ReadLine();
char[] arr1 = StrToCharArr(str1);
Console.WriteLine(arr1);
foreach (var item in arr1)
{
    Console.Write(item + ", ");
}
