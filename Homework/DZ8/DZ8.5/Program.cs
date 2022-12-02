// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] array = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

// Я не знаю как сделать числа в формате 02... поэтому сделал проверку, которая добавляет 0 для чисел до 10
// программа заполнила массив верно, но я чувствую что можно намного легче (типа проверка что число 0, есди нет, или граница то поворот в право)

int[,] PrintArray(int[,] array) // вывести массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (array[i, j] > 9)
            {
                Console.Write(array[i, j] + " ");
            }
            else
            {
                Console.Write("0" + array[i, j] + " ");
            }

        }
        Console.WriteLine();
    }
    return array;
}


int num = 1;

while (num < 4)
{

    for (int j = 0; j < 4; j++)
    {
        int i = 0;
        array[i, j] = num;
        num++;
    }
    for (int i = 1; i < 4; i++)
    {
        int j = 3;
        array[i, j] = num;
        num++;
    }
    for (int j = 2; j > 0; j--)
    {
        int i = 3;
        array[i, j] = num;
        num++;
    }
    for (int i = 3; i > 0; i--)
    {
        int j = 0;
        array[i, j] = num;
        num++;
    }
    for (int j = 1; j < 3; j++)
    {
        int i = 1;
        array[i, j] = num;
        num++;
    }
    for (int j = 2; j > 0; j--)
    {
        int i = 2;
        array[i, j] = num;
        num++;
    }
}
PrintArray(array);

