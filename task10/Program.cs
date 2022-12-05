Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a/100>0 && a/100<10)
{
a = a%100;
a = a/10;
Console.WriteLine(a);
}
else
Console.WriteLine("Error");