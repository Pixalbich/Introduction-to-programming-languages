// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

/* int [] array = { -8, 5, 78, -11 };
for (int i = 0; i < array.Length; i++)
{
    array[i]= -array[i];
    Console.Write(array[i]+" ");
}
 */
 int [] array = { -8, 5, 78, -11 };
 int [] array2 = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    array2[i]= -array[i];
    
}
 Console.Write(string.Join(" ",array));
 Console.WriteLine();
 Console.Write(string.Join(" ",array2));
