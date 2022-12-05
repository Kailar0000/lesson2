Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int max1 = 0;
int max2 = 0;

while(a>0)
{
    if(a>max1)
    {
        max2 = max1;
        max1 = a;
    }
    else
    {
        if(a>max2)
        max2 = a;
    }
    Console.Write("Введите число: ");
    a = Convert.ToInt32(Console.ReadLine());
}
Console.Write(max2);