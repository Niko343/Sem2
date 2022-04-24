Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 % num2 == 0)
{
    Console.WriteLine($"Число {num2} кратно числу {num1}");
}
else
{
    Console.WriteLine($"Число {num1} делится на {num2} с остатком {num1 % num2}");
}


