Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0)
{
    if (num % 23 == 0)
    {
        Console.WriteLine($"Число {num} делится на 7 и на 23");
    }
    else 
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Нет");
}
