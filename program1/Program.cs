// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Задайте размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

ArrayRandomNumbers(array);// Заполнение массива трехзначными числами.Вывод созданного массива на экран.
EvenNumbers(array); // Вычисление четных чисел в массиве.

void ArrayRandomNumbers(int[] array) 
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(100,1000);
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write(" ] - созданный массив,");
}
void EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
        
        
    }
    Console.WriteLine($"количество четных чисел в массиве ( {count} )");
}
