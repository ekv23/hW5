//Задача 3: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

void FillNewArray(double [] Array)
{
 Console.Write("Случайный массив вещественных чисел: ");
 for (int i = 0; i < Array.Length; i++)
 {
 Array[i] = new Random().Next(-20, 20);
 Console.Write($"{Array[i]} ");
 } 
Console.WriteLine();
double Max = 0;
double Min = 0;

for (int x = 0; x < Array.Length; x++)
{
    if(Array[x] >= Max) Max=Array[x];
    if(Array[x] <= Min) Min=Array[x];
}
double result = Max - Min;

Console.WriteLine($"Максимальное число: {Max}.");
Console.WriteLine($"Минимальное число: {Min}.");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива {result}");
}

Console.WriteLine("Введите количество чисел в массиве");
int a = Convert.ToInt32(Console.ReadLine());
double [] array = new double [a];
FillNewArray(array);
