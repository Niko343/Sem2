// Задача 13: Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей
//цифры нет.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (num < 1000 & num > 99)
{
    Console.WriteLine(num % 10);
}
else if (num < 10000  & num > 999)
{
    Console.WriteLine(num / 10 % 10);
}
else if (num < 100000 & num > 9999)
{
    Console.WriteLine(num / 100 % 10);
}
else if (num < 1000000 & num > 99999)
{
    Console.WriteLine(num / 1000 % 10);
}
else if (num < 10000000 & num > 999999)
{
    Console.WriteLine(num / 10000 % 10);
}
else if (num < 100000000 & num > 9999999)
{
    Console.WriteLine(num / 100000 % 10);
}
else if (num < 1000000000 & num > 99999999)
{
    Console.WriteLine(num / 1000000 % 10);
}
else if (num < 10000000000 & num > 999999999)
{
    Console.WriteLine(num / 10000000 % 10);
}
else if (num < 100000000000 & num > 9999999999)
{
    Console.WriteLine(num / 100000000 % 10);
}
else 
{
    Console.WriteLine("Введите число не больше девятизначного");
}