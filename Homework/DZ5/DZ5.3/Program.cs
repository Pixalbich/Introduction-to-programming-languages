// Задача 38: Задайте массив вещественных чисел.  (Любое число +- и 0)
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/* 
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

 */

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
Console.WriteLine("Имеется погрешность, поэтому добавил окгругление до знака 'acc' ");
double[] array = { 2.4, 5, 30, 7, 22, 2.4, 78.6, 40, 45, 55, 70, 11 };

int acc = 1; // точность, до какого знака(почти все варианты протестировал*, работает отлично)

void Print(double word)      //метод выводит значение в консоль
{
    Console.WriteLine(word);
}

double Raznica(double max, double min) //Метод определяет максимальное и минимальное значение и возвращаеи разницу
{
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
    }
    return max - min;
}
double Rou(double value ,int accuracy) // Метод перемещает запятую (76,19...=>761,9)(accuracy - кол раз)  округляем (761,9=>762) и делим на 10(762=>76,2)(accuracy - кол раз) 
{
        int x=1;
        for (int i = 0; i < accuracy; i++)
        {
            value*=10;
            x*=10;
        }
    return Math.Round(value)/x;
}

Print(Rou(Raznica(array[0], array[0]), acc)); //обращение к методу



