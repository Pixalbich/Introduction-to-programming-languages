// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

//Метод вывода массива
int[,] PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" | ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }
        Console.WriteLine();
    }
    return array;
}
PrintArray(matrix); // Можно закомментировать
int stolbec =0;

for (int i = 0; i < matrix.GetLength(1); i++) 
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sum+= matrix[j,i];
        
       
    }
    stolbec++;
    sum= (Math.Floor(sum/matrix.GetLength(0)*10))/10;
    Console.WriteLine("Среднее арефметическое " + stolbec + " столбца  равно "+ sum);
}
