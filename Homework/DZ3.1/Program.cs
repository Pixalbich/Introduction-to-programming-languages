﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (зеркальное 123321 12321  123|321)

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число для определения, является ли оно палиндромом(зеркальное)");
int N = Convert.ToInt32(Console.ReadLine());

string num = N.ToString(); //перевожу N в массив num
int i = num.Length; // колличество символов в массиве
if (i==5)
{
    if (num[0]== num[4]&&num[1]== num[3])
    {
    Console.WriteLine("Введенное число является палиндромом!");
    }
    else
    {
    Console.WriteLine("Введенное число НЕ является палиндромом");
    }
}

else
{
    Console.WriteLine("Ошибка. Нужно ввести пятизначное число!");
}


