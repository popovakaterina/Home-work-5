// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write("Введите размер массива: ");
int A = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[A];
Random rand = new Random();
for (int i = 0; i < Array.Length; i++) // Заполнение массива случайными числами 
{
    Array[i] = rand.Next(100,999); 
    Console.WriteLine(Array[i]); // Выводим массив на экран для проверки
}
int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array [i] % 2 ==0 )
    {
        count ++;
    }
}
Console.Write("Количество четных чисел массива: ");
Console.Write(count);