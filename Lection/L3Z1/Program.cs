/* Река несла по ветру льдины,
Была весна, и ветер выл.
Из отпылавшего камина
Неясный мрак вечерний плыл.
И он сидел перед камином,
Он отгорел и отстрадал
И взглядом, некогда орлиным,
Остывший пепел наблюдал.
В вечернем сумраке всплывали
Пред ним виденья прошлых дней,
Будя старинные печали
Игрой бесплотною теней.
Один, один, забытый миром, */

string text = "Река несла по ветру льдины, "
+ "Была весна, и ветер выл. "
+ "Из отпылавшего камина "
+ "Неясный мрак вечерний плыл. "
+ "И он сидел перед камином, "
+ "Он отгорел и отстрадал "
+ "И взглядом, некогда орлиным, "
+ "Остывший пепел наблюдал. "
+ "В вечернем сумраке всплывали "
+ "Пред ним виденья прошлых дней, "
+ "Будя старинные печали "
+ "Игрой бесплотною теней. "
+ "Один, один, забытый миром. ";
string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ','_');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к','К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'И','и');/* (newText, 'С','с'); */
Console.WriteLine(newText);
Console.WriteLine();
