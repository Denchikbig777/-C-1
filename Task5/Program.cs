//Задача №7. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.Write("Введите число N:");
int numberN = int.Parse(Console.ReadLine());
int numberN2 = numberN%10;
Console.Write (numberN2);