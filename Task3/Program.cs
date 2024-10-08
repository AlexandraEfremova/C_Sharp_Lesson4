﻿// Считать с консоли строку, состоящую из цифр и 
// латинских букв. Сформировать новую строку, 
// состоящую из букв исходной строки.

string GetLettersFromString(string s)
{
    string letters = "";
    foreach(char e in s)
    {
        // IsAsciiLetter(e) - проверит является ли символ буквенным
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLettersFromString(str);
System.Console.WriteLine(result);

