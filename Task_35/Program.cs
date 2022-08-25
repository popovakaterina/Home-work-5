﻿//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] Array = new int[123]; // размер массива 123 эл-та
Random rand = new Random();
for (int i = 0; i < Array.Length; i++) // Заполнение массива случайными числами 
{
    Array[i] = rand.Next(200); // Максимальное значение случайного числа 200 - в дз условия нет ,поставила рандомное значение
   // Console.WriteLine(Array[i]); - выводила для проверки из 5 эл-ов массива
}
int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array [i] >= 10 && Array[i]<=99)
    {
        count ++;
    }
}
Console.Write("Количество элементов массива, значения которых лежат в отрезке [10,99] =  ");
Console.Write(count);