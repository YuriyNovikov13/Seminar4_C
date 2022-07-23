// 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Определение суммы цифр в числе");
Console.Write("Ввидите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Sum(int number)
{
    int sum = 0;
    int i = number;
    while (i != 0)
    {
        sum = sum + i % 10;
        i = i / 10;
    }
    return sum;
}
int result = Number(num);
Console.Write($"сумма цифр числа {num}, равна {result}");