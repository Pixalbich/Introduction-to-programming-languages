// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

System.Console.WriteLine("Задайте количество столбцов");
int col = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задайте количество строк");
int row = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[row, col];
int[,] GetArray(int[,] array) // задать массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
int[,] PrintArray(int[,] array) // вывести массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
PrintArray(GetArray(array));
Console.WriteLine("--------------------------------");

int summ = 2147483647;
int StrMinSum = 0;
int SS = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        SS += array[i, j];
    }
    if (summ > SS)
    {
        summ = SS;
        StrMinSum = Convert.ToInt32(i) + 1;
        Console.WriteLine("Сумма " + (Convert.ToInt32(i) + 1) + " строки равна " + SS);
        SS = 0;
    }
    else
    {
        Console.WriteLine("Сумма " + (Convert.ToInt32(i) + 1) + " строки равна " + SS);
        SS = 0;
    }
}
Console.WriteLine("Строка с наименьшей суммой элементов: " + StrMinSum + " строка");

