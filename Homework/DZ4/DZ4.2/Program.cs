// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите число для подсчета суммы чисел в числе");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма всех чисел в числе равна " + SumCifrVChisle(num));
int SumCifrVChisle(int i)
{
    int sum = 0;
    while (i > 0)
    {
        sum += i % 10;
        i = i / 10;
    }
    return sum;
}



