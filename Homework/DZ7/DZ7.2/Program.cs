// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Write("Введите позицию столбца: ");
int a = Convert.ToInt32(Console.ReadLine()) -1;

Console.Write("Введите позицию строки: ");
int b = Convert.ToInt32(Console.ReadLine()) -1;
// Делаем массив 4 на 4
Console.WriteLine("Для наглядности:");
int n = 4; //столбцы //a
int m = 4; //строки  //b
int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.Write(" | ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " | ");
    }
    Console.WriteLine();
}
if (n>=a&&m>=b)
{
    Console.WriteLine("Значение элемента, который вы указали ");
    Console.WriteLine("равно "+matrix[b,a]);
}
else
{
    Console.WriteLine("ОШИБКА! Данная позиция не входит в массив.");
}