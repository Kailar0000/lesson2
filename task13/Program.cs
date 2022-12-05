Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i1 = 0;
int i2 = 0;
int i3 = 0;
int x = 0;

while(a>0)
{
    x = x+1;
    i3 = i2;
    i2 = i1;
    i1 = a%10;
    a = a/10;
}
if(x>2)
    Console.WriteLine(i3);
else
    Console.WriteLine("Третьей цифры нет");