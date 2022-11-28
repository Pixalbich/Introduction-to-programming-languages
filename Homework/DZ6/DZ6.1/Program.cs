// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Данная программа сообщает сообщает, сколько чисел больше 0 вы ввели");
Console.Write("Сколько чисел вы собираетесь вводить? ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write("Введите " + (i + 1) + " число:");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Вы ввели числа " + String.Join(", ", array) + ".");
if (count > 0)
{
    Console.WriteLine("Из них " + count + " больше нуля.");
}
else
{
    Console.WriteLine("Среди введенных чисел нет тех, что больше нуля.");
}

