//void PrintImage()  //Тип переменной, название, (), {}
/* 
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
 */
/* 
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetSumNum(num));

int GetSumNum(int res)
{
    int sum =0;
    int count =0;

    while(count<res)
    {
        count++;
        sum +=count;

    }
    return sum;

}
 */

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSumNum(num));
int GetSumNum(int res)
{
    int sum = 0;
    int count = 0;
    while(count<res)
    {
        count++;
        sum+= count;  //sum=sum+count;
        
    }
    return sum;   //int GetSumNum(int res)нам вернули (int res)=sum как num
}
// GetSumNum();
// Console.WriteLine(GetSumNum());
