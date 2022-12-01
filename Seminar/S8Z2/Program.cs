// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

/* System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество строк");
int collumns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, collumns];
int[,] GetArray() // задать массив
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);

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

int[,] ChangeArray(int[,] array)  //поменять строки
{
    int[,] array2 = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[i, j] = array[j, i];
        }

    }
    return array2;
}
if (rows != collumns) // не равен
{
    System.Console.WriteLine("В этой матрице нельзя поменять строи и столбцы ");

}
else
{
    PrintArray(GetArray());
    Console.WriteLine("_____________");
    PrintArray(ChangeArray(array));

} */
System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество строк");
int collumns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, collumns];
int[,] GetArray() // задать массив
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);

        }


    }
    return array;
}

void PrintArray(int[,]array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        
           Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
    
    
}
int [,] ChangeArray(int [,] array)
{
    

    int [,] array2 = new int[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[j,i] =array[i,j];
        }
    }
    return array2;
    

}

PrintArray(GetArray());
 Console.WriteLine("____________");
PrintArray(ChangeArray(array));

