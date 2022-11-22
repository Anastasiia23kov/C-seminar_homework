//Задача 4. 
//Программа на вход принимает 3 числа и выдает 
//максимальное из этих чисел.

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int p = Convert.ToInt32(Console.ReadLine());

int max = n;

if (n > max) max = n;
if (m > max) max = m;
if (p > max) max = p;

    Console.Write("max = ");
    Console.WriteLine(max);