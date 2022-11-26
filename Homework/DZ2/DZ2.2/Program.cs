/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */
Console.WriteLine("Программа выводит, если есть третью цифру заданного числа.");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    string th = num.ToString();
    Console.WriteLine(th[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}

// Задание на семинаре, другой способ. Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// int  num = new Random ().Next(100,100000);
// Console.WriteLine(num);
// int result =0;
// while(result==0)
// {
//     if (num>99&&num<1000)
//     {
//         result= num %10;
//     }
//     num/=10;
// }
// Console.WriteLine(result);
