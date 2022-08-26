// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write("Введите размер массива: ");
int A = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[A];
Random rand = new Random();
Console.Write("Введите максимальное число массива массива: "); // Задаем до какго числа будут генерироваться случайные числа в массиве
int B = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < Array.Length; i++) // Заполнение массива случайными числами 
{
    Array[i] = rand.Next(B); 
    Console.WriteLine(Array[i]); // Выводим массив на экран для проверки
}
int summa = 0;
for (int i = 1; i < A; i+=2) // Начинаем с 1 позиции, тк 0 является четной, и перепрыгиваем через 1 позицию, те 1 позиция + 3 позиция и тд.
{
    summa = summa + Array[i];
}
Console.WriteLine("Сумма чисел, стоящих на нечетных позиция равна = " + summa);