/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.WriteLine("Данная программа сообщает какое из трех чисел самое больше");
Console.WriteLine("введите первое число");
int num1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int num3= Convert.ToInt32(Console.ReadLine()); 
    if (num1 >= num2) 
    {
        if (num1 >= num3)
        Console.WriteLine(num1);
        else
        Console.WriteLine(num3);
    }
    else
    {
       if (num2 >= num3)
        Console.WriteLine(num2);
        else
        Console.WriteLine(num3);
    }
  