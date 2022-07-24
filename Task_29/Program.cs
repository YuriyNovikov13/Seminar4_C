// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
// заполненный псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.WriteLine("Введите количество элементов: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
Random rand = new Random();
int[] FillArrey(int num)
{
    for (int i = 0; i < array.Length; i++)
    { array[i] = rand.Next(0, 100); }
    return array;
}
 void PrintArray(int[] col)
 {
     Console.Write("[");
     int count = col.Length;
     Console.Write($"{col[0]}");
     for (int position = 1; position < count; position++)
     { 
        Console.Write(", ");
        Console.Write($"{col[position]}");
      
      }
     Console.Write("]");
 }
int[] arr = FillArrey(num);
PrintArray(arr);