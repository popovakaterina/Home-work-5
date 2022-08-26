Console.Write("Введите размер массива: ");
int A = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[A];
Random rand = new Random();
for (int i = 0; i < Array.Length; i++) // Заполнение массива случайными числами 
{
    Array[i] = rand.Next(20); // Максимальное значение случайного числа 20 - в дз условия нет ,поставила рандомное значение
    Console.WriteLine(Array[i]); // Выводим массив на экран для проверки
}
int couple; // количество пар заданном массиве
if (A % 2 == 0) // если четное количество
{
    couple = A / 2;
    int[] Result = new int [couple];
    for (int j = 0; j < couple/2; j++) // Заполнение массива случайными числами
    {
        for (int i = 0; i < couple; i++)
        {
            int proisv = Array[i] * Array[A - 1 - i];
            //Console.WriteLine("Произведение " + proisv);
            Result[j] = proisv;
            Console.WriteLine("результат умножения пар чисел в массиве с четным количеством эл-ов: "+Result[j]); // Выводим массив на экран для проверки
            
        }   
    }
   
}
else // если нечетное количество
{
    couple = (A-1)/2 +1; // При нечетном количестве значений добавляем 1 эл-т к массиву (он ни с чем не умножается)
    int[] Result = new int [couple];
    for (int j = 0; j < (couple-1)/2; j++) // Заполнение массива случайными числами
    {
        for (int i = 0; i < couple-1; i++)// Игнорируем число в середине 
    {
        {
            int proisv = Array[i] * Array[A - 1 - i];
            //Console.WriteLine("Произведение " + proisv);
            Result[j] = proisv;
            Console.WriteLine("результат умножения пар чисел в массиве с нечетным количеством эл-ов: "+Result[j]); // Выводим массив на экран для проверки
            
        }  
               
    }
        int midd = ((Array.Length/2)+1)-1; // Число без пары просто выводим, тк его не на что умножать
        Console.WriteLine("результат умножения пар чисел в массиве с нечетным количеством эл-ов: " + Array[midd]); 
    }
   
}