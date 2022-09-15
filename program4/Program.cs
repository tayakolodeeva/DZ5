// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
Console.WriteLine("Задайте размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

ArrayRandomNumbers(array);// Заполнение массива числами.Вывод созданного массива на экран.
PairsOfElements(array); // Произведение пар чисел.

void ArrayRandomNumbers(int[] array) 
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(0,1000);
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write(" ] - созданный массив,");
}
void PairsOfElements(int[] array)
{
    int j = array.Length - 1;
    Console.Write(" результат произведения пар чисел массива [ ");
    for (int i = 0; i < (array.Length + 1) / 2; i++)
    {
        if (i == j)
        {
            Console.Write(" (для элемента не нашлось пары "+array[i]+")");
        }
        else 
        {
            Console.Write(" "+array[i] * array[j]+" ");
            j--;
        }
    }
    Console.Write(" ]");

}