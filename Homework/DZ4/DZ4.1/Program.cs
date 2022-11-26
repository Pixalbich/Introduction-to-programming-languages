// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите число, которое нужно ввести в степень: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число, в степень которого нужно возвести число: ");
int b = Convert.ToInt32(Console.ReadLine());
double Pow(double Num, int Nn) //число , натуральное число
{
     double result = 1;

     for (int i = 0; i < Nn; i++)
     {
        result *= Num;
     }
     return result;
}

double res = Pow(a, b);
Console.WriteLine($"{a} в степени {b} равно {res}");
