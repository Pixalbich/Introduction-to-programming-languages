// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] arr = new double[8];

double[] Getarray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        double r = new Random().Next(-10000, 10000);
        array[i] = r/100;
    }
    return array;
}
Getarray(arr);


double Getdif(double[] arr)
{
    double dif = 0;
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
        dif = max - min;
     
    }
    Console.WriteLine($"Разница между {max} - {min} = {dif}");

    return dif;

}
Getdif(arr);
double dif = Getdif(arr);
Console.WriteLine(String.Join(" ", arr));