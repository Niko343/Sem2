//Задача 15: Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
Console.WriteLine("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());
if (num == 6 | num == 7)
{
    Console.WriteLine("Выходной");
} 
else if (num < 6 & num > 0)
{
    Console.WriteLine("Не выходной");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}