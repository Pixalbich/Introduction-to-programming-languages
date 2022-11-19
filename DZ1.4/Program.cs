/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */
/* Console.WriteLine("введите число, до которого нужно показать все четные числа.");
int N = Convert.ToInt32(Console.ReadLine());
int P =4;
    
    do 
{
    Console.Write(P-2+", ");
    P=P+2;
}
    while (P<N-2);
    Console.Write(P+"."); */
Console.WriteLine("введите число(больше 1), до которого нужно показать все четные числа.");
int N = Convert.ToInt32(Console.ReadLine());
int P =1;
 if (N<=1)
  Console.Write("введите число больше 1");
 else{
    do 
    {   if (P % 2 == 0) 
        if (P<N)
        Console.Write(P+", ");
    
        else
        Console.Write(" ");
        P=P+1;
    }
    while (P<N-1);
    if (P % 2 == 0) 
    Console.Write(P+".");
    else
    Console.Write(P+1+".");
 }