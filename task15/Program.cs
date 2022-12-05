Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a == 6 || a == 7)
    Console.WriteLine("Да");
else if(a>7)
    Console.WriteLine("Error");
else
    Console.WriteLine("Нет");