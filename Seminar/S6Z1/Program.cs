// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
System.Console.Write("Введите число: ");
int X = Convert.ToInt32(Console.ReadLine());

string DvoichnoeIschislenie( int num)           // Метод перевода в двоичную систему
{
string result = "";
while (X>0)
{
    result = X%2+result;
    X/=2;                                       // X=X/2;               
}
return result;
}
System.Console.Write(DvoichnoeIschislenie(X));