//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("введите любое число ");
int one = Convert.ToInt32(Console.ReadLine());
if (one > 7 || one < 1)
    Console.Write($"вы ввели {one} это не верный день недели");
else if (one > 5)
    Console.Write($"введёный день {one} выходной");
else
    Console.Write($"введёный день {one} не выходной");

