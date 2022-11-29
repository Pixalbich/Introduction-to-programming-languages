// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
Console.WriteLine("Введите количество столбцов.");
int collumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строчек.");
int rows = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows, collumns];
for (int i = 0; i < rows; i++)              // i < matrix.GetLengh(0)
{
    for (int j = 0; j < collumns; j++)        // j < matrix.GetLengh(1)
    {
        matrix [i,j] = new Random().Next(0,12);
        System.Console.Write(matrix [i,j]+" "); // записываем строчки
    }
    System.Console.WriteLine();                 // разграничить строчки
}