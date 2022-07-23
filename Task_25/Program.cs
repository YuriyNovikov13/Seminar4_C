// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Возвдение числа А в натуральную степень В");
Console.Write("Ввидите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int Exponentiation(int number1, int number2)
{
    int exp = number1;
    for (int num = 2; num <= number2; num++)
    {
        exp = exp * number1;
    }
    return exp;
}
int result = Exponentiation(a, b);
Console.WriteLine($"Число {a} в степени {b}, равно {result}");

