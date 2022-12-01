// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива

System.Console.WriteLine("Введите количество строк");
int rows =Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество строк");
int collumns = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows,collumns];
int[,] GetArray() // задать массив
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]= new Random().Next(0,11);
            
        }


    }
    return array;
}

int[,] PrintArray(int[,]array) // задать массив
{
  for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
            
        }
    Console.WriteLine();

    }
    return array;
}

int[,] ChangeRows(int [,] array)  //поменять строки
{
    int RowsCount =array.GetLength(0)-1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = array [0,i];
        array [0,i] = array[RowsCount,i];
        array[RowsCount,i] = temp;
    }
    return array;
}
PrintArray(GetArray());
 Console.WriteLine("_____________");
 PrintArray(ChangeRows(array));
