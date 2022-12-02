// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = { { { 66, 27 }, { 25, 90 }, { 34, 26 }, { 41, 55 } } };

// System.Console.WriteLine("Задайте количество столбцов"); //если поменять на рандом
// int col = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Задайте количество строк");
// int row = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Задайте количество рядов в элементе ячейки");
// int ko = Convert.ToInt32(Console.ReadLine());
// int[,,] array = new int[row, col, ko];

int[,,] GetArray(int[,,] array) // задать массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            for (int k = 0; k < array.GetLength(2); k++)
            {
                // array[i, j, k] = new Random().Next(10, 100); //если поменять на рандом
                Console.WriteLine(array[i, j, k] + "(" + i + ", " + j + ", " + k + ")");
            }
        }
    }
    return array;
}

GetArray(array);
