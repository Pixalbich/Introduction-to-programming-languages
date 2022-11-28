// Задача 39: Напишите программу, которая перевернёт
//  одномерный массив (последний элемент будет на первом
//   месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Console.Write(" N =  ");
// int n = Convert.ToInt32(Console.ReadLine());

int []array = new int [6];

int [] GetArray(int[] array)                    // Заполнить массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
        
    }
    return array;
}
int [] ChangeArray(int[] array)                 // развернуть массив
{
    for (int i = 0; i <  array.Length/2; i++)
    {
      
        int temp = array[i];
        array[i] = array[array.Length-i-1];
        array[array.Length-i-1] = temp;

    }
    return array;
}
Console.WriteLine(String.Join(",",GetArray(array)));
Console.WriteLine();
Console.WriteLine(String.Join(",",ChangeArray(array)));
