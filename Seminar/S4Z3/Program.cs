int GetCounNum(int res)
{
   
    
    if(res<0){
         res = - res;
    }
    
    int count =0;

    while(res>0)
    {
        count++;
        res/=10;

    }
    return count;

}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Колличество цифр "+GetCounNum(num));
