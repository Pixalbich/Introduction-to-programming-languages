// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами. (-1000..., 1000...)
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Данная программа создает двумерный массив из вещественных чисел(до десятичных, например -10.4 и 3.0)");

Console.Write("Укажите, сколько знаков должно быть в числе(пример 10.3 = 3 знака. 0,2 = 2 знака): ");
int h = Convert.ToInt32(Console.ReadLine());

int hor = 1000;
hor = Convert.ToInt32(Math.Pow(10, h)) / 10;
Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
if(h <= 1)
{
    Console.Write("ОШИБКА! Минимум знаков должно быть 2");
}
else
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double r = new Random().Next(-hor + 1, hor) / Math.Pow(10, 1);
            matrix[i, j] = r;
            Console.Write(matrix[i, j] + " | ");
        }
        Console.WriteLine();
    }

}