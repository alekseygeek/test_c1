// показать 2 числа больше или меньше 
Console.Clear();
Console.Write("ведите первое число :");
int a = int.Parse(Console.ReadLine());
Console.Write("введите второе число :");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("наибольше  :" + a);
    Console.WriteLine("наименьшее :" + b);
}
else
{
    Console.WriteLine("наибольше  :" + b);
    Console.WriteLine("наименьшее :" + a);
}
