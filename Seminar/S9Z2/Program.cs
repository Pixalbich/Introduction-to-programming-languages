// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
// Задача 65: Задайте значения M и N. Напишите
//  программу, которая выведет все натуральные 
//  числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите начальное число");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное число");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNum(n,m));

string PrintNum(int start, int end)
{
    if (start==end)
    {
        return end.ToString();
    }
    return(start+ " "+PrintNum(start +1,  end));
   
}
