//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
//Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

string[] names = { "qwe", "wer", "ert", "rty", "tyu", "ytr" };

int FindWordByVowel(string[] words)
{
    int count = 0;
    for (int i = 0; i < words.Length; i++)
        if (words[i][0] == 'a' || words[i][0] == 'e' || words[i][0] == 'i' || words[i][0] == 'o' || words[i][0] == 'u' || words[i][0] == 'y') count++;
    return count;
}
//Console.WriteLine(FindWordByVowel(names));






//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, 
//объединяя элементы исходного массива попарно.

//Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] names2 = { "само", "лёт", "отвё", "ртка", "сгущ", "ёнка", "элетро", "станция" };

string[] Split(string[] a)
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


void Show(string[] a)
{
    for (int i = 0; i < a.Length; i++)
        Console.Write(a[i] + ", ");
}

Show(Split(names2));
