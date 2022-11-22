//Программа на вход принимает 2 числа и выдает, 
//какое число большее, а какое меньшее.

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n > m)
{
    Console.Write("max = ");
    Console.WriteLine(n);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(m);
}