// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.



System.Console.Write("Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите 3 число: ");
int c = Convert.ToInt32(Console.ReadLine());
// c<a+b
if (c<=a+b&&a<=c+b&&b<=a+c)
{
   System.Console.Write("Данные числа могут быть сторонами треугольника"); 
}
else
{
    System.Console.Write("Данные числа не могут быть сторонами треугольника"); 
}