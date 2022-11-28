// Задача 44: Не используя рекурсию, выведите 
// первые N чисел Фибоначчи. Первые два числа Фибоначчи
// : 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Console.Write(" N =  ");
// int n = Convert.ToInt32(Console.ReadLine());


Console.Write(" N =  ");
int n = Convert.ToInt32(Console.ReadLine());

int firstEl =0;
int secondEl =1;


for (int i = 0; i < n; i++)
{
    int nextEl = firstEl+secondEl;
    Console.Write(firstEl+" , ");
    firstEl=secondEl;
    secondEl=nextEl;
}
System.Console.WriteLine();