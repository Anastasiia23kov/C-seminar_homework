//Задача 6. 
//Программа на вход принимает число и выдает, является ли
//число четным (делится ли оно на 2 без остатка).

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.Write("да, ваше число четное ");
}
else
{
    Console.Write("нет, ваше число нечетное ");
}