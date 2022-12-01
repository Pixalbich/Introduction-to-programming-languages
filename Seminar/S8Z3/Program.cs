// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество строк");
int collumns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, collumns];
int minVal = Int32.MaxValue;
int indexRows = 0;
int indexCollumns = 0;
int[,] GetArray() // задать массив
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            if (minVal > array[i, j])
            {
                minVal = array[i, j];
                indexRows = i;
                indexCollumns = j;
            }
        }


    }
    return array;
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }


}
int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != indexRows)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != indexCollumns)
                {
                    Console.Write(array[i, j]);
                }
            }
        }
        Console.WriteLine();
    }
return array;

}

PrintArray(GetArray());
Console.WriteLine("____________");
ChangeArray(array);

