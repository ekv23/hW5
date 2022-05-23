//Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

void FillNewArray(int[] Array)
{
 Console.Write("Случайный массив: ");
 for (int i = 0; i < Array.Length; i++)
 {
 Array[i] = new Random().Next(-20, 20);
 Console.Write($"{Array[i]} ");
 } 
Console.WriteLine();
int Summ = 0;
for (int x = 0; x < Array.Length; x++)
{
    if (x%2 != 0) Summ += Array[x];
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {Summ}.");
}
Console.WriteLine("Введите количество чисел в массиве");
int a = Convert.ToInt32(Console.ReadLine());
int[]Array = new int [a];
FillNewArray(Array);