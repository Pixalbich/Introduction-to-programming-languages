// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] FormatArray(int[,] array) // форматировать массив
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) //4 2 3
        {
            for (int k = j + 1; k <array.GetLength(1); k++)  // Не получилось сделать без еще одного цикла
            {
                if (array[i,j] > array[i,k])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    return array;
}

int[,] PrintArray(int[,] array) // задать массив
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
PrintArray(FormatArray(array));
