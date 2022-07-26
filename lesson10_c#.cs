//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
//Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

string[] names = { "qwe", "wer", "Ert", "rty", "tyu", "ytr" };
char[] dict = { 'a', 'e', 'i', 'o', 'u', 'y' };

int FindWordByVowel(string[] words) //простой перебор
{
    int count = 0;
    for (int i = 0; i < words.Length; i++)
        if (words[i].ToLower()[0] == 'a' || words[i].ToLower()[0] == 'e' || words[i].ToLower()[0] == 'i' || words[i].ToLower()[0] == 'o' || words[i].ToLower()[0] == 'u' || words[i].ToLower()[0] == 'y')
            count++;
    return count;
}
Console.WriteLine(FindWordByVowel(names));


int FindWordByVowel2(string[] words) //по словарю
{
    int count = 0;
    for (int i = 0; i < words.Length; i++)
        for (int j = 0; j < dict.Length; j++)
            if (words[i].ToLower()[0] == Char.ToLower(dict[j])) count++;
    return count;
}
Console.WriteLine(FindWordByVowel2(names));





//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, 
//объединяя элементы исходного массива попарно.

//Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] names2 = { "само", "лёт", "отвё", "ртка", "сгущ", "ёнка", "элетро", "станция" };

string[] Join(string[] a)
{
    int c = 0;
    string[] b = new string[a.Length / 2];
    for (int i = 0; i < a.Length / 2; i++)
    {
        b[i] = a[c] + a[c + 1];
        c += 2;
    }
    return b;
}

void Show(string[] str)
{
    for (int i = 0; i < str.Length; i++)
        Console.Write(str[i] + ", ");
}

Show(Join(names2));
