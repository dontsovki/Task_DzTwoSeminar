// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("введите любое число ");
string str = Console.ReadLine();
char[] a=str.ToCharArray();

int len = a.Length;
if (len != 3)
    Console.Write($"вы ввели {str} это число не трёхзначное");
else
    Console.Write($"Третье число {a[1]} из числа {str}");
