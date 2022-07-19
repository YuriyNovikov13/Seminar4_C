// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Возвдение числа А в натуральную степень В");
Console.Write("Ввидите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = Convert.ToInt32(Math.Pow (a, b)); 
Console.Write($"Число {a} в степени {b} -> {result}");