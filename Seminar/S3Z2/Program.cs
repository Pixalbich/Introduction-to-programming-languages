/* Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой четверти (x и y).
 */

Console.WriteLine("Введите номер четверти");
int  ch = Convert.ToInt32(Console.ReadLine());
if (ch == 1)
{
    Console.WriteLine("x>0 y>0");
}
else if (ch == 2)
{
    Console.WriteLine("x<0 y>0");
}
else if (ch == 3)
{
    Console.WriteLine("x<0 y<0");
}
else if (ch == 4)
{
    Console.WriteLine("x>0 y<0");
}
else
{
    Console.WriteLine("ОШИБКА");
}
