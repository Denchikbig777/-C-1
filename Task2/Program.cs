//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b =10 -> нет
//a = 9, b = -3 -> да
//a = -3, b = 9 -> нет


Console.Write("Введите число A:");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
int result = numberB*numberB;

if(numberA == result)
{
    Console.WriteLine("Число A является квадратом числа B");
}
else
{
    Console.WriteLine("Число A не является квадратом числа B");
}