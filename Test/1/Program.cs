// // Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементов массива.

// // [3 7 22 2 78] -> 76

// double[] arr = new double[8];

// double[] Getarray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         double r = new Random().Next(-10000, 10000);
//         array[i] = r/100;
//     }
//     return array;
// }
// Getarray(arr);


// double Getdif(double[] arr)
// {
//     double dif = 0;
//     double max = arr[0];
//     double min = arr[0];
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] < min) min = arr[i];
//         if (arr[i] > max) max = arr[i];
//         dif = max - min;

//     }
//     Console.WriteLine($"Разница между {max} - {min} = {dif}");

//     return dif;

// }
// Getdif(arr);
// double dif = Getdif(arr);
// Console.WriteLine(String.Join(" ", arr));


// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9 
// m = 3, n = 2 -> A(m,n) = 29 
 Console.WriteLine("Введите начальное число"); 
int n = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Введите начальное число"); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(A(n,m)); 
 int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}