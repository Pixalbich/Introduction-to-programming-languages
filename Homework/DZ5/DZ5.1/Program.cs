// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Уточните размер массива");
int massize = Convert.ToInt32(Console.ReadLine());
int[] RandomArray(int size)
{
    int[] array = new int[size];
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        int Arra = (array[i]);
        if (Arra % 2 == 0) { count++; } //знаю что не красиво не переносить фигурные скобки, но всего 1 условие.
    }
    Console.WriteLine(count + " - количество четных элементов в массиве: ");
    return array;
}
int[] array = RandomArray(massize);

Console.Write(String.Join(", ", array));

/* Console.WriteLine("Уточните размер массива");
int massize = Convert.ToInt32(Console.ReadLine());
int PosArray(int num) 
{
    int[] array = new int[num];
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(100,1000);
        int Arra = (array[i]);
        if (Arra%2==0)
        {
            count++;
        }
    }
    Console.WriteLine(count+" - количество четных элементов в массиве: ");
    return count;
}
int array = PosArray(massize);

Console.Write(array); */