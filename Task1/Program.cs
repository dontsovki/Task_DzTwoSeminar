// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("введите любое трёхзначное число ");
string str = Console.ReadLine();
   Console.WriteLine("Вы ввели не трехзначное число");
char[] a=str.ToCharArray();
Console.Write($"Второе число {a[1]} из числа {str}");

//Console.Write("введите любое трёхзначное число");
//string str = Console.ReadLine();
//       Console.WriteLine(str is char[]);

    

//char[] str = s.ToCharArray();



//int num = Convert.ToInt32(Console.ReadLine());
//int lengt = num.ToString().Length;

//if (lengt < 3 || lengt > 3)
//    Console.WriteLine("Вы ввели не трехзначное число");
//else
//   Console.WriteLine(InCenter(num));


