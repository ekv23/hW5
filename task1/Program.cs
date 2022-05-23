//Задача 1: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

void FillNewArray(int[] Array)
{
 Console.Write("Случайный массив: ");
 for (int i = 0; i < Array.Length; i++)
 {
 Array[i] = new Random().Next(100, 999);
 Console.Write($"{Array[i]} ");
 } 
 Console.WriteLine();
 int count = 0;
 for (int x = 0; x < Array.Length; x++)
 {
 if(Array[x]%2 == 0) count++; 
 }
 Console.WriteLine($"Количество четных чисел в массиве: {count}");
}
Console.WriteLine("введите количество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
FillNewArray(array);
Console.WriteLine();