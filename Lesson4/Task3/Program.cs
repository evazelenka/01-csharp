﻿string GetLetters(string s)
{
    string letters = "";
    foreach(char e in s)
    {
        if(char.IsLetter(e) == true)
        {
            letters += e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLetters(str);
Console.WriteLine(result);
