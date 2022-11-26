// Задача 38: Задайте массив вещественных чисел.  (Любое число +- и 0)
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = { 2.4,  76.6};

double MaxMin(double result)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }

        result = max - min;
    }
    return result;
}
Console.WriteLine(MaxMin(array[0]));



/* double [] array =  {2,7,22,2.4,78.6} ;  

    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
            // Console.Write("+"+max);
        }
        if (array[i] < min)
        {
            min = array[i];
            // Console.Write("-"+min);
        }
        double result = max - min;   
    }
    Console.WriteLine(max-min);
 */