/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */
Console.WriteLine("Программа выводит, если есть третью цифру заданного числа.");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    string str = num.ToString();
    Console.WriteLine(str[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}