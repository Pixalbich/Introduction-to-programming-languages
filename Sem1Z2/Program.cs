// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/* 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет */
Console.WriteLine("введите первое число");
int num1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2= Convert.ToInt32(Console.ReadLine());
int sqt = num*num;
Console.WriteLine("квадрат числа "+ num+ " равен "+sqt);
