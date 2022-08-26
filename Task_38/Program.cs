//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] Array = new double[size];
Random rand = new Random();
Console.Write("Введите миннимальное число для случайного массива: "); // Задаем с какого числа будут генерироваться случайные числа в массиве
int minnumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число для случайного массива: "); // Задаем до какого числа будут генерироваться случайные числа в массиве
int maxnumb = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < Array.Length; i++) // Заполнение массива случайными числами 
{
    Array[i] = rand.Next(minnumb,maxnumb); 
    Console.WriteLine(Array[i]); // Выводим массив на экран для проверки
}
double max = Array[0];
double min = Array[0];
for (int i = 0; i < size; i++) 
{
    if (Array[i]> max )
    {
        max = Array[i];
    }
     if (Array[i]< min )
    {
        min = Array[i];
    }      

}
Console.WriteLine("Максимальное значеине массива = "+ max);
Console.WriteLine("Миннимальное значеине массива = "+ min);
